
namespace CameraBazar.Web.Controllers
{
    using Data.Models;
    using Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Models.Users;

    public class UsersController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IUserService users;

        public UsersController(UserManager<User> userManager, IUserService users)
        {
            this.userManager = userManager;
            this.users = users;
        }

        [Authorize]
        public IActionResult YourProfile(string id)
            => this.View(this.users.ById(id));

        [Authorize]
        public IActionResult Profile(string id)
        {
            var currentUser = this.userManager.GetUserId(this.User);

            if (currentUser != id)
            {
                return this.View(this.users.ById(id));
            }

            return this.RedirectToAction(nameof(this.YourProfile), new { id });
        }


        [Authorize]
        public IActionResult Edit(string id)
        {
            var user = this.users.UserDetailsById(id);

            if (user == null)
            {
                return this.NotFound();
            }

            return this.View(new UserViewModel()
            {

                Email = user.Email,
                NewPassword = "",
                Phone = user.Phone,
                CurrentPassword = ""
            });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(string id, UserViewModel userModel)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            if (user == null)
            {
                return this.NotFound();
            }

            if (userModel.NewPassword != null)
            {
                await this.userManager.ChangePasswordAsync(user, userModel.CurrentPassword, userModel.NewPassword);
            }

            if (!this.ModelState.IsValid || this.users.HasSameEmail(userModel.Email))
            {
                return this.View(userModel);
            }

            this.users.Edit(id,userModel.Email,userModel.Phone);

            return this.RedirectToAction(nameof(this.YourProfile), new { id });
        }

    }
}
