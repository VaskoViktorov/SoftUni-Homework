using System;

namespace BashSoft.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public const string InvalidCommand = "The command '{0}' is invalid";

        public InvalidCommandException(string entry) 
            : base(string.Format(InvalidCommand, entry))
        {
        }    
    }
}
