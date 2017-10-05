namespace WebServer.Server.HTTP.Contracts
{
    using Enums;

    public interface IHttpResponce
    {
        HttpStatusCode StatusCode { get; }

        HttpHeaderCollection Headers { get; }
    }
}
