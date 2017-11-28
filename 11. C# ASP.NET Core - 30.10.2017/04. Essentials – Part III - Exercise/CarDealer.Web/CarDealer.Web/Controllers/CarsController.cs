namespace CarDealer.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Infrastructure.Extensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Services;
    using Microsoft.AspNetCore.Mvc;
    using Models.Cars;

    [Route("cars")]
    public class CarsController : Controller
    {
        private const string ModelType = "car";

        private readonly ICarService cars;
        private readonly IPartService parts;
        private readonly ILogService logs;

        public CarsController(ICarService cars, IPartService parts, ILogService logs)
        {
            this.cars = cars;
            this.parts = parts;
            this.logs = logs;
        }

        [Route("{make}", Order = 2)]
        public IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return this.View(new CarsByMakeModel
            {
                Cars = cars,
                Make = make
            });
        }

        [Route("parts", Order = 1)]
        public IActionResult Parts()
            => this.View(this.cars.WithParts());

        [Route("{id}/parts", Order = 3)]
        public IActionResult Details(int id)
            => this.ViewOrNotFound(this.cars.Details(id));

        [Authorize]
        [Route(nameof(Create))]
        public IActionResult Create()
            => this.View(new CarFormModel
            {
                AllParts = this.GetParts()
            });

        [Authorize]
        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(CarFormModel carModel)
        {
            if (!this.ModelState.IsValid)
            {
                carModel.AllParts = this.GetParts();
                return this.View(carModel);
            }

            this.cars
                .Create(carModel.Make, carModel.Model, carModel.TravelledDistance, carModel.SelectedParts);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.Parts));
        }

        private IEnumerable<SelectListItem> GetParts()
        => this.parts
            .All()
            .Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            });

    }
}
