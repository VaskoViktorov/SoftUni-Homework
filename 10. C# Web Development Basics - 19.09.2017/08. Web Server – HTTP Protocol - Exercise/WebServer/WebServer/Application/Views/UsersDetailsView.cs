namespace WebServer.Application.Views
{
    using Server.Contracts;
    using Server;

    public class UsersDetailsView : IView
    {
        private readonly Model model;

        public UsersDetailsView(Model model)
        {
            this.model = model;
        }

        public string View()
        {
            return $"<body>Hello, {this.model["name"]}!</body>";
        }
    }
}
