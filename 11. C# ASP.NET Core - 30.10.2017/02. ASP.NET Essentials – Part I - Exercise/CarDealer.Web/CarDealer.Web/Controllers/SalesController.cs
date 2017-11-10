

namespace CarDealer.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Infrastructure.Extensions;

    [Route("sales")]
    public class SalesController : Controller
    {
        private readonly ISaleService sales;

        public SalesController(ISaleService sales)
        {
            this.sales = sales;
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
    }
}
