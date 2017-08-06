using System;
using System.Collections;
using System.Collections.Generic;

namespace BashSoft.Contracts
{
    public interface IRequester
    {
        void GetStudentsScoreFromCourse(string courseName, string username);

        void GetAllStudentFromCourse(string courseName);

        ISimpleOrderedBag<ICourse> GetAllCoursesSorted(IComparer<ICourse> cmp);

        ISimpleOrderedBag<IStudent> GetAllStudentsSorted(IComparer<IStudent> cmp);
    }
}
