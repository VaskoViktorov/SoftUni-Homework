namespace LearningSystem.Services
{
    using Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data.Models;

    public interface ITrainerService
    {
        Task<IEnumerable<CourseListingServiceModel>> CoursesAsync(string trainerId);

        Task<bool> IsTrainerAsync(int courseId, string trainerId);

        Task<IEnumerable<StudentInCourseServiceModel>> StudentsInCourseAsync(int courseId);

        Task<bool> AddGradeAsync(int courseId,string userId, Grade grade);
    }
}
