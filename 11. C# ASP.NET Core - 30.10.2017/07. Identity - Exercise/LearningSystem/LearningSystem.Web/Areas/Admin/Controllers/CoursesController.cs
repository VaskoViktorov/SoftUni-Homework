namespace LearningSystem.Web.Areas.Admin.Controllers
{
    using Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Models.Courses;
    using Services.Admin;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Web.Controllers;
    using Infrastructure.Extensions;
    using Infrastructure.Filters;

    public class CoursesController : BaseController
    {
        private const string CourseCreateMessage = "Course {0} created successfully.";
        private readonly IAdminCourseService courses;
        private readonly UserManager<User> userManager;

        public CoursesController(UserManager<User> userManager, IAdminCourseService courses)
        {
            this.courses = courses;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Create()
            => this.View(new AddCourseFormModel
                {
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(100),
                    Trainers = await this.GetTrainers()
                });


        [HttpPost]   
        public async Task<IActionResult> Create(AddCourseFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.Trainers = await this.GetTrainers();
                return this.View(model);
            }

            await this.courses.Create(model.Name, model.Description, model.StartDate, model.EndDate, model.TrainerId);

            this.TempData.AddSuccessMessage(string.Format(CourseCreateMessage, model.Name));

            return this.RedirectToAction(nameof(HomeController.Index), "Home", new { area=string.Empty});
        }

        private async Task<IEnumerable<SelectListItem>> GetTrainers()
        {
            var trainers = await this.userManager
                .GetUsersInRoleAsync(WebConstants.TrainerRole);

            var trainersListItems = trainers.Select(t => new SelectListItem
            {
                Text = t.UserName,
                Value = t.Id
            })
                .ToList();

            return trainersListItems;
        }
    }
}
