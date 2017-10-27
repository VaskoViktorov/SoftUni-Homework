using App.GameStore.Models.Users;
using App.GameStore.Services;
using App.GameStore.Services.Contracts;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Contracts;

namespace App.GameStore.Controllers
{
    public class UsersController : BaseController
    {
        private const string RegisterError = "<p>Email must contain . and @.</p><p> Password must be at least 6 symbols and must contain at least one Uppercase one Lowercase and one Digit. </p>";
        private const string EmailExistsError = "<p>Email is already taken!</p>";
        private const string LoginError = "<p>Invalid credentials.</p>";

        private IUserService users;

        public UsersController()
        {
            this.users = new UserService();
        }

        public IActionResult Register() => this.View();

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (model.Password != model.ConfirmPassword || !this.IsValidModel(model))
            {
                this.ShowError(RegisterError);
                return this.View();
            }

            var result = this.users.Create(model.Email, model.Password, model.Name);

            if (result)
            {
                return this.Redirect("/users/login");
            }

            this.ShowError(EmailExistsError);
            return this.View();
        }

        public IActionResult Login() => this.View();

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (!this.IsValidModel(model))
            {
                this.ShowError(LoginError);
                return this.View();
            }

            if (this.users.UserExists(model.Email, model.Password))
            {
                this.SignIn(model.Email);
                return this.Redirect("/");
            }

            this.ShowError(LoginError);
            return this.View();
        }

        public IActionResult Logout()
        {
            this.SignOut();
           return this.Redirect("/");
        }
    }
}
