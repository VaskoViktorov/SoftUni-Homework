namespace LearningSystem.Services
{
    using System.Threading.Tasks;
    using Models;

    public interface IUserService
    {
        Task<UserProfileServiceModel> ProfileAsync(string username);
    }
}
