namespace WebServer.Server.HTTP.Responce
{
    using Enums;
    using Common;

    public class RedirectResponce : HttpResponce
    {
        public RedirectResponce(string redirectUrl)
            : base()
        {
            CoreValidator.ThrowIfNullOrEmpty(redirectUrl, nameof(redirectUrl));

            this.StatusCode = HttpStatusCode.Found;
            
            this.Headers.Add(new HttpHeader("Location", redirectUrl));
           
        }

    }
}
