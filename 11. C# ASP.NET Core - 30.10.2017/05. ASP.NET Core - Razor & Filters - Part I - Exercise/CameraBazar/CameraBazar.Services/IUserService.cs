using CameraBazar.Services.Models.Users;

namespace CameraBazar.Services
{
    public interface IUserService
    {
        UserModel ById(string id);

        UserDetailsModel UserDetailsById(string id);

        void Edit(string id, string email, string phone);

        bool HasSameEmail(string userModelEmail);
    }
}
