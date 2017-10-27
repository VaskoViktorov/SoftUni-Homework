using System;
using System.Collections.Generic;
using App.GameStore.Data.Models;
using App.GameStore.Models.Games;

namespace App.GameStore.Services.Contracts
{
    public interface IGameService
    {
        void Create(string title, string description, string thumbnail,
            decimal price, double size, string videoId, DateTime releaseDate);

        Game GetById(int id);

        IEnumerable<GameListingAdminModel> All();

        void Delete(int id);

        void Update(int id, string title, string description, string thumbnail, decimal price, double size, string videoId, DateTime releaseDate);
    }
}
