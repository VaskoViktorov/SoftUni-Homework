namespace WebServer.Application.Views
{
    using Server.Contracts;

    public class HomeIndexView : IView
    {
        public string View()
        {
            return "<body><h1>Welcome<a href=\"http://127.0.0.1:1337/register \">click</a></h1></body>";
        }
    }
}
