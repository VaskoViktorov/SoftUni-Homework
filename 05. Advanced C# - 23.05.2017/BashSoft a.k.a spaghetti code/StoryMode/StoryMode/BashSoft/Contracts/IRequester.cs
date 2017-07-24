using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Contracts
{
    public interface IRequester
    {
        void GetStudentsScoreFromCourse(string courseName, string username);
        void GetAllStudentFromCourse(string courseName);
    }
}
