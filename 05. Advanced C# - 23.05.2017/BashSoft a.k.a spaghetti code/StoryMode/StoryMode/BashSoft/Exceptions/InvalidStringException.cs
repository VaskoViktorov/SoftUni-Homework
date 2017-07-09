using System;

namespace BashSoft.Exceptions
{
    public class InvalidStringException : Exception
    {
        public const string InvalidString = "The value of the variable CANNOT be null or empty!";

        public InvalidStringException() 
            : base(InvalidString)
        {
        }

        public InvalidStringException(string message)
            : base(message)
        {
        }
    }        
}
