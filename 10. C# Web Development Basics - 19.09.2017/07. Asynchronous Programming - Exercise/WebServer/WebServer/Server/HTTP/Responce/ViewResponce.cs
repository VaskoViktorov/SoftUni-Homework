using System;

namespace WebServer.Server.HTTP.Responce
{
    using Enums;
    using Server.Contracts;
    using Exceptions;

    public class ViewResponce : HttpResponce
    {
        private readonly IView view;

        public ViewResponce(HttpStatusCode statusCode, IView view) 
            : base()
        {
            this.ValidateStatusCode(statusCode);

            this.view = view;
            this.StatusCode = statusCode;
        }

        private void ValidateStatusCode(HttpStatusCode statusCode)
        {
            var statusCodeNumber = (int) statusCode;
            if ( 299 <statusCodeNumber && statusCodeNumber < 400)
            {
                throw new InvalidResponceException("View responces need a status code below 300 and above 400 (inclusive)");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.view.View()}";
        }

    }
}
