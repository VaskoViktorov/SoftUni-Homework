namespace WebServer.Application.Controllers
{
    using Views;
    using Server.Enums;
    using Server.HTTP.Contracts;
    using Server.HTTP.Responce;

    public class HomeController
    {

        // GET /
        public IHttpResponce Index()
        {
            return new ViewResponce(HttpStatusCode.Ok, new HomeIndexView());
        }
    }
}
