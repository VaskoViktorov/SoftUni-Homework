using System;
using System.Collections.Generic;
using System.Linq;
using App.GameStore.Data;
using App.GameStore.Data.Models;
using App.GameStore.Models.Games;
using App.GameStore.Services.Contracts;

namespace App.GameStore.Services
{
    public class GameService : IGameService
    {
        public void Create(string title, string description, string thumbnail, decimal price, double size,
            string videoId, DateTime releaseDate)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = new Game
                {
                    Title = title,
                    Description = description,
                    ThumbnailUrl = thumbnail,
                    Price = price,
                    Size = size,
                    VideoId = videoId,
                    ReleaseDate = releaseDate
                };

                db.Games.Add(game);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = db.Games.Find(id);
                db.Games.Remove(game);
                db.SaveChanges();
            }
        }

        public Game GetById(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Games.Find(id);
            }
        }

        public void Update(int id, string title, string description, string thumbnail, decimal price,
            double size, string videoId, DateTime releaseDate)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = db.Games.Find(id);

                game.Title = title;
                game.Description = description;
                game.ThumbnailUrl = thumbnail;
                game.Price = price;
                game.Size = size;
                game.VideoId = videoId;
                game.ReleaseDate = releaseDate;

                db.SaveChanges();
            }
        }

        public IEnumerable<GameListingAdminModel> All()
        {
            using (var db = new GameStoreDbContext())
            {
                return db
                    .Games
                    .Select(g => new GameListingAdminModel()
                    {
                        Id = g.Id,
                        Name = g.Title,
                        Size = g.Size,
                        Price = g.Price
                    })
                    .ToList();             
            }
        }

       
    }
}
