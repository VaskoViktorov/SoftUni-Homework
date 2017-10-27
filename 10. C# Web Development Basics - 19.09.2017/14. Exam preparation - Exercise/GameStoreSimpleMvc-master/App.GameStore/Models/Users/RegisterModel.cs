namespace App.GameStore.Models.Users
{
    using Infrastructure.Validation;
    using Infrastructure.Validation.Users;

    public class RegisterModel
    {
        [Required]
        [Email]
        public string Email { get; set; }

        public string Name { get; set; }

        [Required]
        [Password]
        public string Password { get; set; }

        [Required]
        [Password]
        public string ConfirmPassword { get; set; }
    }
}
