using System;


namespace BashSoft.Exceptions
{
    public class DataAlreadyInitialisedException : Exception
    {
        public const string DataAlreadyInitialised = "Data is already initialized!";

        public DataAlreadyInitialisedException() : base(DataAlreadyInitialised)
        {

        }

        public DataAlreadyInitialisedException(string message)
            : base(message)
        {

        }
    }
}
