using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {                      
            int numOfLines = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10}|{1, 7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average");

            for (int i = 0; i < numOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' ', ',', '-', '\n','\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                double[] grades = input.Skip(1).Select(double.Parse).ToArray();
                
                Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", input[0], grades[0], grades[1], grades[2], grades.Average());

            }

        }
    }
}
