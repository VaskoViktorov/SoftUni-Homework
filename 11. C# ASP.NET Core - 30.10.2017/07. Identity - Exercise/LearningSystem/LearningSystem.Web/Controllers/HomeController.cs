using System.Threading.Tasks;
using LearningSystem.Services;

namespace LearningSystem.Web.Controllers
{
    using Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    public class HomeController : Controller
    {
        private readonly ICourseService courses;

        public HomeController(ICourseService courses)
        {
            this.courses = courses;
        }

        public async Task<IActionResult> Index()
        =>this.View(await  this.courses.ActiveAsync());
        

        public IActionResult Error()
        => this.View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier
        });
        
    }
}
