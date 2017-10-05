namespace WebServer.Server.Exceptions
{
    using System;

    public class InvalidResponceException : Exception
    {
        public InvalidResponceException(string message)
            :base(message)
        {           
        }
    }
}
