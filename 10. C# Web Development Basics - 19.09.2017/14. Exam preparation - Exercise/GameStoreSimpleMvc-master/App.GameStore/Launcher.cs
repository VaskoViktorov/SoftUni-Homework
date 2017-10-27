using App.GameStore.Data;
using Microsoft.EntityFrameworkCore;
using SimpleMvc.Framework;
using SimpleMvc.Framework.Routers;
using WebServer;

namespace App.GameStore
{
    public class Launcher
    {
        static Launcher()
        {
            using (var db = new GameStoreDbContext())
            {
                db.Database.Migrate();
            }
        }

        public static void Main()
            => MvcEngine.Run(
                new WebServer.WebServer(1337, new ControllerRouter(), new ResourceRouter()));

    }
}
