namespace CarDealer.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Infrastructure.Extensions;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Models.Sales;
    using Microsoft.AspNetCore.Mvc.Rendering;

    [Route("sales")]
    public class SalesController : Controller
    {
        private const string ModelType = "sale";

        private readonly ISaleService sales;
        private readonly ICarService cars;
        private readonly ICustomerService customers;
        private readonly ILogService logs;

        public SalesController(ISaleService sales, ICarService cars, ICustomerService customers, ILogService logs)
        {
            this.sales = sales;
            this.cars = cars;
            this.customers = customers;
            this.logs = logs;
        }

        [Route("")]
        public IActionResult All()
            => this.View(this.sales.All());

        [Route("{id}")]
        public IActionResult Details(int id)
            => this.ViewOrNotFound(this.sales.Details(id));

        [Route("discounted")]
        public IActionResult Discounted()
            => this.View(this.sales.Discounted());

        [Route("discounted/{percent}")]
        public IActionResult DiscountedPercent(double percent)
            => this.ViewOrNotFound(this.sales.DiscountedPercent(percent));

        [Route(nameof(Create))]
        public IActionResult Create()
            => this.View(new SaleFormModel
            {
                AllCars = this.GetCarListItems(),
                AllCustomers = this.GetCustomerListItems()
            });


        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(SaleFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.AllCars = this.GetCarListItems();
                model.AllCustomers = this.GetCustomerListItems();
                return this.View(model);
            }          
            return this.RedirectToAction(nameof(this.Review), model);
        }

        [Route(nameof(Review))]
        public IActionResult Review(SaleFormModel model)
            => this.View(new ReviewFormModel
            {
                CustomerId = model.CustomerId,
                IsYoungDriver = this.customers.ById(model.CustomerId).IsYoungDriver,
                CustomerName = this.customers.ById(model.CustomerId).Name,
                CarId = model.CarId,
                CarName = this.cars.ById(model.CarId).MakeModel,
                Discount = (model.Discount + (this.customers.ById(model.CustomerId).IsYoungDriver? 5:0))/100,
                CarPrice = this.cars.ById(model.CarId).Price               
            });

        [HttpPost]
        [Route(nameof(Review))]
        public IActionResult Review(ReviewFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            this.sales
                .Create(model.CarId, model.CustomerId, model.Discount);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.All));
        }

        private IEnumerable<SelectListItem> GetCustomerListItems()
            => this.customers
                .AllCustomers()
                .Select(s => new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Id.ToString()
                });

        private IEnumerable<SelectListItem> GetCarListItems()
            => this.cars
                .AllCars()
                .Select(s => new SelectListItem
                {
                    Text = s.Model,
                    Value = s.Id.ToString()
                });
    }
}

