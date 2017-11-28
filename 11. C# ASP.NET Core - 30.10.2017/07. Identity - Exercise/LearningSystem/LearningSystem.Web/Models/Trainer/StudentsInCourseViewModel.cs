namespace LearningSystem.Web.Models.Trainer
{
    using System.Collections.Generic;
    using Services.Models;

    public class StudentsInCourseViewModel
    {
        public IEnumerable<StudentInCourseServiceModel> Students { get; set; }

        public CourseListingServiceModel Course { get; set; }
    }
}
