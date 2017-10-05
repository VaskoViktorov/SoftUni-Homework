namespace WebServer.Server.HTTP.Responce
{
    using Enums;

    public class NotFoundResponce : HttpResponce
    {
        public NotFoundResponce()
        {
            this.StatusCode = HttpStatusCode.NotFound;
        }
    }
}
