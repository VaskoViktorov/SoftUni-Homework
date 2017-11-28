namespace CameraBazar.Services.Models.Users
{
    using System;

    public class UserDetailsModel
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public DateTime LasLogin { get; set; }
    }
}
