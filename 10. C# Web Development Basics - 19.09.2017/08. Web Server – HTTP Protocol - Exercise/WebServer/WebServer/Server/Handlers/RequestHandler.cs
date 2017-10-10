namespace WebServer.Server.Handlers
{
    using Contracts;
    using HTTP.Contracts;
    using System;
    using Common;
    using HTTP;

    public abstract class RequestHandler: IRequestHandler
    {
        private readonly Func<IHttpRequest, IHttpResponse> handlingFunc;

        protected RequestHandler(Func<IHttpRequest, IHttpResponse> handlingFunc)
        {
            CoreValidator.ThrowIfNull(handlingFunc, nameof(handlingFunc));
            this.handlingFunc = handlingFunc;
        }

        public IHttpResponse Handle(IHttpContext context)
        {
            var responce = this.handlingFunc(context.Request);

            responce.Headers.Add(new HttpHeader("Content-Type", "text/html"));

            return responce;
        }
    }
}
