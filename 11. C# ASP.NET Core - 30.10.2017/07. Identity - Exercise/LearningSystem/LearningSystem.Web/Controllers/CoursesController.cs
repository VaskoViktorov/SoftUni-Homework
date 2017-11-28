namespace LearningSystem.Web.Controllers
{
    using Data.Models;
    using Infrastructure.Extensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Models.Courses;
    using Services;
    using Services.Models;
    using System.Threading.Tasks;

    public class CoursesController : Controller
    {
        private readonly ICourseService courses;
        private readonly UserManager<User> userManager;

        public CoursesController(ICourseService courses, UserManager<User> userManager)
        {
            this.courses = courses;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = new CourseDetailsViewModel
            {
                Course = await this.courses.ByIdAsync<CourseDetailsServiceModel>(id),
            };

            if (model.Course == null)
            {
                return this.NotFound();
            }

            if (this.User.Identity.IsAuthenticated)
            {
                var userId = this.userManager.GetUserId(this.User);
                model.UserIsSignedInCourse =
                    await this.courses.UserIsSignedInCourse(id, userId);
            }

            return this.View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SignIn(int id)
        {
            var userId = this.userManager.GetUserId(this.User);

            var success = await this.courses.SignInUser(id, userId);
            if (!success)
            {
                return this.BadRequest();
            }

            this.TempData.AddSuccessMessage("Thank you for signing up!");

            return this.RedirectToAction(nameof(this.Details), new { id });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SignOut(int id)
        {
            var userId = this.userManager.GetUserId(this.User);

            var success = await this.courses.SignOutUser(id, userId);

            if (!success)
            {
                return this.BadRequest();
            }

            this.TempData.AddSuccessMessage("Sorry to see you go.");

            return this.RedirectToAction(nameof(this.Details), new { id });
        }
    }
}
