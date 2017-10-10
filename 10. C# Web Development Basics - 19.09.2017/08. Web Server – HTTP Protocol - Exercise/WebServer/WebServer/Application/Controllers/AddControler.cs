namespace WebServer.Application.Controllers
{
    using System;
    using System.IO;
    using Views;
    using Server.Enums;
    using Server.HTTP.Responce;
    using Server.HTTP.Response;

    public class AddControler
    {

        public HttpResponse AddGet()
        {
            return new ViewResponse(HttpStatusCode.Ok, new AddView());
        }

        public HttpResponse AddPost(string name, string price)
        {
            this.SaveToDb(name, price);

            return new RedirectResponse("\\add");
        }

        private void SaveToDb(string name, string price)
        {
            File.AppendAllText("cakes.txt", $"{name}@{price}" + Environment.NewLine);
        }


    }
}
