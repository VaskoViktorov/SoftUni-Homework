namespace WebServer.Server.Routing
{
    using System.Collections.Generic;
    using Enums;
    using Contracts;
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ServerRouteConfig : IServerRouteConfig
    {
        private readonly IDictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>> routes;

        public ServerRouteConfig(IAppRouteConfig appRouteConfig)
        {
            this.routes = new Dictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>>();

            var availableMethods = Enum
                .GetValues(typeof(HttpRequestMethod))
                .Cast<HttpRequestMethod>();

            foreach (var method in availableMethods)
            {
                this.routes[method] = new Dictionary<string, IRoutingContext>();
            }

            this.InitializeServerConfig(appRouteConfig);
        }

        public IDictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>> Routes => this.routes;

        private void InitializeServerConfig(IAppRouteConfig appRouteConfig)
        {
            foreach (var registratedRoute in appRouteConfig.Routes)
            {
                var requestMethod = registratedRoute.Key;
                var routeWithHandlers = registratedRoute.Value;

                foreach (var routeWithHandler in routeWithHandlers)
                {
                    var route = routeWithHandler.Key;
                    var handler = routeWithHandler.Value;

                    var parameters = new List<string>();

                    var parsedRouteRegex = this.ParseRoute(route, parameters);

                    var routingContext = new RoutingContext(handler,parameters);

                    this.routes[requestMethod].Add(parsedRouteRegex, routingContext);
                }
            }
        }

        private string ParseRoute(string route, List<string> parameters)
        {
            var result = new StringBuilder();
            result.Append("^");

            if (route == "/")
            {
                result.Append("/$");
                return result.ToString();
            }
            var tokens = route.Split(new [] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            result.Append("/");
            this.ParseTokens(tokens, parameters,result);

            return result.ToString();
        }

        private void ParseTokens(string[] tokens, List<string> parameters, StringBuilder parsedRegex)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                string end = i == tokens.Length - 1 ? "$" : "/";
                var currentToken = tokens[i];
                if (!currentToken.StartsWith("{") && !currentToken.EndsWith("}"))
                {
                    parsedRegex.Append($"{currentToken}{end}");
                    continue;
                }

                Regex parameterRegex = new Regex("<\\w+>");
                Match parameterMatch = parameterRegex.Match(currentToken);

                if (!parameterMatch.Success)
                {
                    throw new InvalidOperationException($"Route parameter in {currentToken} is not valid.");
                }

                var match = parameterMatch.Value;
                var parameter = match.Substring(1, match.Length - 2);

                parameters.Add(parameter);

                parsedRegex.Append($"{currentToken.Substring(1, currentToken.Length - 2)}{end}");

            }
        }
    }
}
