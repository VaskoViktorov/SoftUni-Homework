using LearningSystem.Services.Models;
using LearningSystem.Web.Models.Trainer;

namespace LearningSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Data.Models;
    using Services;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    [Authorize(Roles = WebConstants.TrainerRole)]
    public class TrainerController : Controller
    {
        private readonly ITrainerService trainers;
        private readonly UserManager<User> userManager;
        private readonly ICourseService courses;

        public TrainerController(ITrainerService trainers, UserManager<User> userManager, ICourseService courses)
        {
            this.trainers = trainers;
            this.userManager = userManager;
            this.courses = courses;
        }

        public async Task<IActionResult> Courses()
        {
            var userId = this.userManager.GetUserId(this.User);
            var courses = await this.trainers.CoursesAsync(userId);

            return this.View(courses);
        }

        public async Task<IActionResult> Students(int id)
        {
            var userId = this.userManager.GetUserId(this.User);

            if (!await this.trainers.IsTrainerAsync(id, userId))
            {
                return this.NotFound();
            }

            return this.View(new StudentsInCourseViewModel
            {
                Students = await this.trainers.StudentsInCourseAsync(id),
                Course = await this.courses.ByIdAsync<CourseListingServiceModel>(id)
            });
        }

        [HttpPost]
        public async Task<IActionResult> GradeStudent(int id, Grade grade, string studentId)
        {
            if (string.IsNullOrEmpty(studentId))
            {
                return this.BadRequest();
            }

            var userId = this.userManager.GetUserId(this.User);

            if (!await this.trainers.IsTrainerAsync(id, userId))
            {
                return this.BadRequest();
            }

            var success = await this.trainers.AddGradeAsync(id, studentId, grade);

            if (!success)
            {
                return this.BadRequest();
            }

            return this.RedirectToAction(nameof(this.Students),new {id});
        }
    }
}
