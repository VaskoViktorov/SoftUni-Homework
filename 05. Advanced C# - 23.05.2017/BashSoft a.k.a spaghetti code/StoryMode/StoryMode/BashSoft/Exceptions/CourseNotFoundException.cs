using System;

namespace BashSoft.Exceptions
{
   public class CourseNotFoundException : Exception
    {
        public const string CourseNotFound = "Student must be enrolled in a course before you set his mark.";

        public CourseNotFoundException() 
            : base(CourseNotFound)
        {
        }

        public CourseNotFoundException(string message)
            : base(message)
        {
        }
    }
}
