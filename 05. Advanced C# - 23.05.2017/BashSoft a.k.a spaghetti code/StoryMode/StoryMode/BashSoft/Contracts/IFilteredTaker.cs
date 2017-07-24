using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Contracts
{
    public interface IFilteredTaker
    {
        void FilterAndTake(string courseName, string givenFilther, int? studentsToTake = null);
    }
}
