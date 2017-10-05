namespace WebServer.Application
{
    using Controllers;
    using Server.Contracts;
    using Server.Handlers;
    using Server.Routing.Contracts;

    public class MainApplication : IApplication
    {
        public void Start(IAppRouteConfig appRouteConfig)
        {
            
            appRouteConfig.AddRoute(
                "/user/{(?<name>[a-z]+)}",
                new GetHandler(httpContext => new UserController()
                    .Details(httpContext.UrlParameters["name"])));

            appRouteConfig.AddRoute(
                "/register",
                new PostHandler(
                    httpContext => new UserController()
                        .RegisterPost(httpContext.FormData["name"])));

            appRouteConfig.AddRoute(
                "/register",
                new GetHandler(httpContext => new UserController()
                    .RegisterGet()));
           
            appRouteConfig.AddRoute(
                "/",
                new GetHandler(httpContext => new HomeController()
                    .Index()));
        }
    }
}
