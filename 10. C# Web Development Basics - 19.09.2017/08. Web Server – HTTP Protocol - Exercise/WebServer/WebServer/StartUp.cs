using WebServer.Application;

namespace WebServer
{
    using Server.Contracts;
    using Server.Routing;

    public class StartUp : IRunnable
    {


        public static void Main()
        {
            new StartUp().Run();
        }

        public void Run()
        {
            var app = new MainApplication();
            var routeConfig= new AppRouteConfig();
            app.Start(routeConfig);
            var webServer= new Server.WebServer(1337,routeConfig);
            webServer.Run();
        }
    }
}
