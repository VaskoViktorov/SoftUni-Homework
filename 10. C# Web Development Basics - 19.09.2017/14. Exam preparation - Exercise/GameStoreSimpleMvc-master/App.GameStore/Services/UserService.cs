﻿using System.Linq;
using App.GameStore.Data;
using App.GameStore.Data.Models;
using App.GameStore.Services.Contracts;

namespace App.GameStore.Services
{
    public class UserService : IUserService
    {
        public bool Create(string email, string password, string name)
        {

            using (var db = new GameStoreDbContext())
            {
                if (db.Users.Any(u => u.Email == email))
                {
                    return false;
                }

                var isAdmin = !db.Users.Any();

                var user = new User()
                {
                    Email = email,
                    Name = name,
                    Password = password,
                    IsAdmin = isAdmin
                };

                db.Add(user);
                db.SaveChanges();

                return true;
            }
        }

        public bool UserExists(string email, string password)
        {
            using (var db = new GameStoreDbContext())
            {
                return db
                    .Users
                    .Any(u => u.Email == email && u.Password == password);              
            }
        }
    }
}
