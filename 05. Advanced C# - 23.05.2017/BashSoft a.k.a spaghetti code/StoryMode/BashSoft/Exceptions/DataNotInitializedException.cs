using System;

namespace BashSoft.Exceptions
{
    public class DataNotInitializedException : Exception
    {
        public const string DataNotInitialized =
            "The data structure must be initialised first in order to make any operations with it.";

        public DataNotInitializedException() : base(DataNotInitialized)
        {
        }

        public DataNotInitializedException(string message)
            : base(message)
        {
        }
    }
}
