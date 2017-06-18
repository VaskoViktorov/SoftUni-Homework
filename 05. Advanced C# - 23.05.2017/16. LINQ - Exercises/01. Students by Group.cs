using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> students = new List<string>();

            while (input != "END")
            {
                students.Add(input);
                input = Console.ReadLine();
            }

          students.Where(s => int.Parse(s.Split().ToArray()[2]) == 2)
                .OrderBy(x => x).ToList()
                .ForEach(s => Console.WriteLine(string.Join(" ",s.Split().Take(2).ToArray())));

        }
    }
}
