using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft.Models;

namespace BashSoft.Contracts
{
    public interface IStudent
    {
        string UserName { get; }

       IReadOnlyDictionary<string, ICourse> EnrolledCourses { get; }

       IReadOnlyDictionary<string, double> MarksByCourseName { get; }

        void EnrollInCourse(ICourse softUniCourse);

        void SetMarkOnCourse(string courseName, params int[] scores);

    }
}
