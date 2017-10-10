namespace WebServer.Application.Views
{
    using System;
    using System.IO;
    using System.Text;
    using Server.Contracts;

    public class SearchView : IView
    {
        public string View()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(File.ReadAllText(@".\Application\Resources\search.html"));

            if (this.SearchResult != null)
            {
                foreach (var cakeArg in this.SearchResult)
                {
                    string[] cake = cakeArg.Split('@', StringSplitOptions.RemoveEmptyEntries);
                    string name = cake[0];
                    string price = cake[1];
                    sb.Append($"<p>{name} ${price}</p>");
                }
            }

            return sb.ToString();
        }

        public string[] SearchResult { private get; set; }
    }
}
