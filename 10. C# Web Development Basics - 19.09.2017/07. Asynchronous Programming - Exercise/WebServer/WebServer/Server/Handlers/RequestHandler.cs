namespace WebServer.Server.Handlers
{
    using Contracts;
    using HTTP.Contracts;
    using System;
    using Common;
    using HTTP;

    public abstract class RequestHandler: IRequestHandler
    {
        private readonly Func<IHttpRequest, IHttpResponce> handlingFunc;

        protected RequestHandler(Func<IHttpRequest, IHttpResponce> handlingFunc)
        {
            CoreValidator.ThrowIfNull(handlingFunc, nameof(handlingFunc));
            this.handlingFunc = handlingFunc;
        }

        public IHttpResponce Handle(IHttpContext context)
        {
            var responce = this.handlingFunc(context.Request);

            responce.Headers.Add(new HttpHeader("Content-Type", "text/html"));

            return responce;
        }
    }
}
