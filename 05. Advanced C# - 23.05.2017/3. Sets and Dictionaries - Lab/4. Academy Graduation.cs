using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication371
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedDictionary<string,List<double>> students = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                List<double> scores = Console.ReadLine().Split(new char[] {' ', '\t', '\n'},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                if (!students.ContainsKey(name))
                {
                    students.Add(name, scores);
                }
               
            }
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
