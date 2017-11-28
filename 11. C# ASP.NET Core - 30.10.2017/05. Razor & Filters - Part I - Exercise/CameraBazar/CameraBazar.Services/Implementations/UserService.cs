namespace CameraBazar.Services.Implementations
{
    using System.Linq;
    using Data;
    using Models.Users;

    class UserService : IUserService
    {
        public readonly CameraBazarDbContext db;

        public UserService(CameraBazarDbContext db)
        {
            this.db = db;
        }

        public UserModel ById(string id)
            => this.db
                .Users
                .Where(c => c.Id == id)
                .Select(c => new UserModel()
                {
                    Id = c.Id,
                    Username = c.UserName,
                    Email = c.Email,
                    Phone = c.PhoneNumber,
                    Cameras = c.Cameras ,
                    InStockQuantity = c.Cameras.Count(p => p.Quantity != 0),
                    OutOfStockQuantity = c.Cameras.Count(p => p.Quantity == 0)
                })
                .FirstOrDefault();

        public UserDetailsModel UserDetailsById(string id)
            => this.db
                .Users
                .Where(c => c.Id == id)
                .Select(c => new UserDetailsModel()
                {
                    Id = c.Id,                    
                    Email = c.Email,
                    Phone = c.PhoneNumber,
                    Password = c.PasswordHash
                })
                .FirstOrDefault();

        public void Edit(string id, string email, string phone)
        {
            var user = this.db.Users.Find(id);
                       
            user.Email = email;
            user.PhoneNumber = phone;

            this.db.SaveChanges();
        }

        public bool HasSameEmail(string userModelEmail)
            =>this.db.Users.Any(u => u.Email == userModelEmail);
       
    }
}
