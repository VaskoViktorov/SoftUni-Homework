

using CarDealer.Web.Infrastructure.Extensions;

namespace CarDealer.Web.Controllers
{
    using Services;
    using Microsoft.AspNetCore.Mvc;
    using Models.Cars;

    [Route("cars")]
    public class CarsController : Controller
    {
        private readonly ICarService cars;

        public CarsController(ICarService cars)
        {
            this.cars = cars;
        }

        [Route("{make}", Order = 2)]
        public IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return View(new CarsByMakeModel
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
    }
}
