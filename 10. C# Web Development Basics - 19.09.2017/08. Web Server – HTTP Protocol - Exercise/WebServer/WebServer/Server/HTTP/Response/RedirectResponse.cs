namespace WebServer.Server.HTTP.Responce
{
    using Enums;
    using Common;

    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string redirectUrl)
            : base()
        {
            CoreValidator.ThrowIfNullOrEmpty(redirectUrl, nameof(redirectUrl));

            this.StatusCode = HttpStatusCode.Found;
            
            this.Headers.Add(new HttpHeader("Location", redirectUrl));
           
        }

    }
}
