using System;
using System.Collections.Generic;
using System.Linq;


namespace BashSoft
{
    public class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                PrintStudents(wantedData.OrderBy(x => x.Value.Sum())
                    .Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));

            }
            else if (comparison == "descending")
            {

                PrintStudents(wantedData.OrderByDescending(x => x.Value.Sum())
                    .Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidComparisonQuery);
            }
        }       

        private static void PrintStudents(Dictionary<string, List<int>> studentSorted)
        {
            foreach (KeyValuePair<string,List<int>> kvp in studentSorted)
            {
                OutputWriter.PrintStudent(kvp);
            }
        }
    }
}
