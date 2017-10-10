

namespace WebServer.Application.Controllers
{
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Server.Enums;
    using Server.HTTP.Responce;
    using Server.HTTP.Response;
    using Views;

    public class SearchController
    {
        public HttpResponse SearchGet()
        {
            return new ViewResponse(HttpStatusCode.Ok, new SearchView());
        }

        public HttpResponse SearchPost(string name)
        {
            string[] cakes = File.ReadAllLines("cakes.txt")
                .Where(c => Regex.IsMatch(c, name, RegexOptions.IgnoreCase))
                .ToArray();

            SearchView sv = new SearchView { SearchResult = cakes };

            return new ViewResponse(HttpStatusCode.Ok, sv);
        }
    }
}
