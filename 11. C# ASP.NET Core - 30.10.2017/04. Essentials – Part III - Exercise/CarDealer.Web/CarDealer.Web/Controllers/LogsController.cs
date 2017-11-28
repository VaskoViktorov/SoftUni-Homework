namespace CarDealer.Web.Controllers
{
    using Services;
    using Services.Models.Logs;
    using Microsoft.AspNetCore.Mvc;

    public class LogsController : Controller
    {
        private readonly ILogService logs;

        public LogsController(ILogService logs)
        {
            this.logs = logs;
        }


        public IActionResult All()
        {

            var result = this.logs.All();

            return this.View(new LogListingModel
            {
                Logs = result
            });
        }

        public IActionResult DeleteAll(int id)
            => this.View();

        public IActionResult Destroy(int id)
        {
            this.logs.Delete();

            return this.RedirectToAction(nameof(this.All));
        }
    }
}
