using System;
using System.Collections.Generic;
using System.Linq;


namespace BashSoft
{
    public class RepositorySorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsMarks, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                this.PrintStudents(studentsMarks.OrderBy(x => x.Value)
                    .Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));

            }
            else if (comparison == "descending")
            {

                PrintStudents(studentsMarks.OrderByDescending(x => x.Value)
                    .Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidComparisonQuery);
            }
        }       

        private void PrintStudents(Dictionary<string, double> studentSorted)
        {
            foreach (KeyValuePair<string,double> kvp in studentSorted)
            {
                OutputWriter.PrintStudent(kvp);
            }
        }
    }
}
