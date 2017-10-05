namespace WebServer.Application.Controllers
{
    using Views;
    using Server.Enums;
    using Server.HTTP.Contracts;
    using Server.HTTP.Responce;
    using Server;

    public class UserController
    {
        public IHttpResponce RegisterGet()
        {
            return new ViewResponce(HttpStatusCode.Ok, new RegisterView());
        }

        public IHttpResponce RegisterPost(string name)
        {
            return new RedirectResponce($"/user/{name}");
        }

        public IHttpResponce Details(string name)
        {
            Model model = new Model{["name"]=name};

            return new ViewResponce(HttpStatusCode.Ok, new UsersDetailsView(model));
        }
    }

}
