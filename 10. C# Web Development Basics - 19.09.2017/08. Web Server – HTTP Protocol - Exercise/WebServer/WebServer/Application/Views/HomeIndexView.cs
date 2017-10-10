using System.IO;
using System.Linq;

namespace WebServer.Application.Views
{
    using Server.Contracts;

    public class HomeIndexView : IView
    {
        public string View()
        {
            string file = File.ReadAllText(@".\Application\Resources\index.html");

            return file;
        }
    }
}
