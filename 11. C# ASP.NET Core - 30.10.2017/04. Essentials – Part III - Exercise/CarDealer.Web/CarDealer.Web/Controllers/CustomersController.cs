namespace CarDealer.Web.Controllers
{
    using Services;
    using Services.Models;
    using Models.Customers;
    using Infrastructure.Extensions;
    using System.Reflection;
    using Microsoft.AspNetCore.Mvc;

    [Route("customers")]
    public class CustomersController : Controller
    {
        private const string ModelType = "customer";

        private readonly ICustomerService customers;
        private readonly ILogService logs;

        public CustomersController(ICustomerService customers, ILogService logs)
        {
            this.customers = customers;
            this.logs = logs;
        }

        [Route(nameof(Create))]
        public IActionResult Create()
            => this.View();

        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(CustomerFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            this.customers
                .Create(model.Name,model.BirthDay,model.IsYoungDriver);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.All), new {order = OrderDirection.Ascending});
        }

        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id)
        {
            var customer = this.customers.ById(id);

            if (customer == null)
            {
                return this.NotFound();
            }

            return this.View(new CustomerFormModel
            {
                Name = customer.Name,
                BirthDay = customer.BirthDay,
                IsYoungDriver = customer.IsYoungDriver
            });
        }

        [HttpPost]
        [Route(nameof(Edit) + "/{id}")]      
        public IActionResult Edit(int id, CustomerFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }
            var customerExists = this.customers.Exists(id);

            if (!customerExists)
            {
                return this.NotFound();
            }

            this.customers
                .Edit(id,model.Name, model.BirthDay, model.IsYoungDriver);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.All), new { order = OrderDirection.Ascending });
        }

        [Route(nameof(Delete) + "/{id}")]
        public IActionResult Delete(int id)
            => this.View(id);

        [Route(nameof(Destroy) + "/{id}")]
        public IActionResult Destroy(int id)
        {
            this.customers.Delete(id);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.All), new { order = OrderDirection.Ascending });
        }

        [Route("all/{order}")]
        public IActionResult All(string order)
        {
            var orderDirection = order.ToLower() == "descending" ? OrderDirection.Descending : OrderDirection.Ascending;

            var result = this.customers.Ordered(orderDirection);

            return this.View(new AllCustomersModel
            {
                Customers = result,
                OrderDirection = orderDirection

            });
        }

        [Route("{id}")]
        public IActionResult TotalSales(int id)
        =>this.ViewOrNotFound(this.customers.TotalSalesById(id));
    }
}
