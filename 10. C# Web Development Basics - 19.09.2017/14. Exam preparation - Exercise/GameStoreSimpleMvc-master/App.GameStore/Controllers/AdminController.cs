using System.Linq;
using App.GameStore.Data.Models;
using App.GameStore.Models.Games;
using App.GameStore.Services;
using App.GameStore.Services.Contracts;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Contracts;

namespace App.GameStore.Controllers
{
    public class AdminController : BaseController
    {
        public const string GameError = "<p>Check your form for errors.</p>";
        private readonly IGameService games;

        public AdminController()
        {
            this.games = new GameService();
        }

        public IActionResult AddGame()
        {
            if (!this.IsAdmin)
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult AddGame(GameAdminModel model)
        {
            if (!this.IsAdmin)
            {
                return this.Redirect("/");
            }

            if (!this.IsValidModel(model))
            {
                this.ShowError(GameError);
                return this.View();
            }

            this.games.Create(
                model.Title,
                model.Description,
                model.Thumbnail,
                model.Price,
                model.Size,
                model.VideoId,
                model.ReleaseDate);

            return this.Redirect("/admin/allgames");
        }

        public IActionResult EditGame(int id)
        {
            if (!this.IsAdmin)
            {
                return this.Redirect("/");
            }

            var game = this.games.GetById(id);

            if (game == null)
            {
                return this.NotFound();
            }

            this.SetGameViewData(game);

            return this.View();
        }

        [HttpPost]
        public IActionResult EditGame(int id, GameAdminModel model)
        {
            if (!this.IsAdmin)
            {
                return this.Redirect("/");
            }

            if (!this.IsValidModel(model))
            {
                this.ShowError(GameError);
                return this.View();
            }

            this.games.Update(
                id,
                model.Title,
                model.Description,
                model.Thumbnail,
                model.Price,
                model.Size,
                model.VideoId,
                model.ReleaseDate);

            return this.Redirect("/admin/allgames");
        }

        public IActionResult DeleteGame(int id)
        {
            if (!this.IsAdmin)
            {
                return this.Redirect("/");
            }

            var game = this.games.GetById(id);

            if (game == null)
            {
                return this.NotFound();
            }

            this.ViewModel["id"] = id.ToString();
            this.SetGameViewData(game);

            return this.View();
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            if (!this.IsAdmin)
            {
                return this.Redirect("/");
            }

            var game = this.games.GetById(id);

            if (game == null)
            {
                return this.NotFound();
            }

            this.games.Delete(id);

            return this.Redirect("/admin/allgames");
        }

        public IActionResult AllGames()
        {
            if (!this.IsAdmin)
            {
                return this.Redirect("/");
            }

            var allGames = this.games
                .All()
                .Select(g => $@"<tr>
                                <td>{g.Id}</td>
                                <td>{g.Name}</td>
                                <td>{g.Size} GB</td>
                                <td>{g.Price} &euro;</td>
                                <td>
                                    <a class=""btn btn-warning btn-sm"" href=""/admin/editgame?id={g.Id}"">Edit</a>
                                    <a class=""btn btn-danger btn-sm"" href=""/admin/deletegame?id={g.Id}"">Delete</a>
                                </td>
                                </tr>");

            this.ViewModel["games"] = string.Join(string.Empty, allGames);

            return this.View();
        }

        protected bool IsAdmin => this.User.IsAuthenticated && this.Profile.IsAdmin;

        private void SetGameViewData(Game game)
        {
            this.ViewModel["title"] = game.Title;
            this.ViewModel["description"] = game.Description;
            this.ViewModel["thumbnail"] = game.ThumbnailUrl;
            this.ViewModel["price"] = game.Price.ToString("F2");
            this.ViewModel["size"] = game.Size.ToString("F1");
            this.ViewModel["videoId"] = game.VideoId;
            this.ViewModel["release-date"] = game.ReleaseDate.ToString("yyyy-MM-dd");
        }
    }
}
