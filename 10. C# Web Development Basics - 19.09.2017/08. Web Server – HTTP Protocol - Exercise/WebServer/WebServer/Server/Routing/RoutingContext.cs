namespace WebServer.Server.Routing
{
    using System.Collections.Generic;
    using Common;
    using Handlers;
    using Contracts;

    class RoutingContext : IRoutingContext
    {
        public RoutingContext(RequestHandler requestHandler, IEnumerable<string> parameters)
        {
            CoreValidator.ThrowIfNull(requestHandler, nameof(requestHandler));
            CoreValidator.ThrowIfNull(parameters, nameof(parameters));

            this.RequestHandler = requestHandler;
            this.Parameters = parameters;
        }

        public IEnumerable<string> Parameters { get; private set; }
        public RequestHandler RequestHandler { get; private set; }
    }
}
