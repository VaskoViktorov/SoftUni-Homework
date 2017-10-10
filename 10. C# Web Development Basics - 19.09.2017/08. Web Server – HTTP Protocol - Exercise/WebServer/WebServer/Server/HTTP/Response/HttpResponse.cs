namespace WebServer.Server.HTTP.Responce
{
    using Enums;
    using System.Text;
    using Contracts;

    public abstract class HttpResponse : IHttpResponse
    {

        private string statusCodeMessage => this.StatusCode.ToString();

        protected HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
        }

        public HttpHeaderCollection Headers { get; set; }

        public HttpStatusCode StatusCode { get; protected set; }

        public override string ToString()
        {
            var responce = new StringBuilder();
            var statusCodeNumber = (int)this.StatusCode;

            responce.AppendLine($"HTTP/1.1 {statusCodeNumber} {this.statusCodeMessage}");
            
            responce.AppendLine(this.Headers.ToString());
            responce.AppendLine();
            
            return responce.ToString();
        }
    }
}
