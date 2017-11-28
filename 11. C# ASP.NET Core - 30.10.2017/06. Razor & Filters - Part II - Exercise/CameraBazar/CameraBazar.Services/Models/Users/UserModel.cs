using System;

namespace CameraBazar.Services.Models.Users
{
    using System.Collections.Generic;
    using Data.Models;

    public class UserModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime LasLogin { get; set; }

        public IEnumerable<Camera> Cameras { get; set; }

        public int InStockQuantity { get; set; }

        public int OutOfStockQuantity { get; set; }
    }
}
