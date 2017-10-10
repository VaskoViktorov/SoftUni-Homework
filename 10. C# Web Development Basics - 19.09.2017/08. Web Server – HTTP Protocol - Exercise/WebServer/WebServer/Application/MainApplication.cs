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
                "/search",
                new GetHandler(httpContext => new SearchController().SearchGet()));

            appRouteConfig.AddRoute(
                "/search",
                new PostHandler(httpContext => new SearchController()
                .SearchPost(
                    httpContext.FormData["name"])));

            appRouteConfig.AddRoute(
                "/add",
                new GetHandler(httpContext => new AddControler().AddGet()));

            appRouteConfig.AddRoute(
                "/add", 
                new PostHandler(httpContext => new AddControler()
                .AddPost(
                    httpContext.FormData["name"],
                    httpContext.FormData["price"])));

            appRouteConfig.AddRoute(
                "/user/{(?<name>[a-z]+)}",
                new GetHandler(httpContext => new UserController()
                    .Details(
                    httpContext.UrlParameters["name"])));

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
