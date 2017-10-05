namespace WebServer.Server.Handlers.Contracts
{
    using HTTP.Contracts;

    public interface IRequestHandler
    {
        IHttpResponce Handle(IHttpContext httpContext);
    }
}