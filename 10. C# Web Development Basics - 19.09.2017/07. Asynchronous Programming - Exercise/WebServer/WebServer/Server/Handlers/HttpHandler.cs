namespace WebServer.Server.Handlers
{
    using System.Text.RegularExpressions;
    using Contracts;
    using HTTP.Responce;
    using Routing.Contracts;
    using HTTP.Contracts;
    using Common;

    class HttpHandler : IRequestHandler
    {
        private readonly IServerRouteConfig serverRouteConfig;

        public HttpHandler(IServerRouteConfig serverRouteConfig)
        {
            CoreValidator.ThrowIfNull(serverRouteConfig,nameof(serverRouteConfig));

            this.serverRouteConfig = serverRouteConfig;
        }

        public IHttpResponce Handle(IHttpContext context)
        {
            var requestMethod = context.Request.Method;
            var requestPath = context.Request.Path;
            var registratedRoutes = this.serverRouteConfig.Routes[requestMethod];
            
            foreach (var registeredRoute in registratedRoutes)
            {
                var routePattern = registeredRoute.Key;
                var routingContext = registeredRoute.Value;

                var routeRegex = new Regex(routePattern);
                var match = routeRegex.Match(requestPath);

                if (!match.Success)
                {
                    continue;
                }
                var parameters = routingContext.Parameters;

                foreach (var parameter in parameters)
                {
                    var parameterValue = match.Groups[parameter].Value;
                    context.Request.AddUrlParameter(parameter, parameterValue);
                }
                return routingContext.RequestHandler.Handle(context);
            }
            return new NotFoundResponce();
        }
    }
}
