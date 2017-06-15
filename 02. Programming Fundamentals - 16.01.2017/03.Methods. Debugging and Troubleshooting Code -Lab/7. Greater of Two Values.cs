using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication200
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                var lineOne = int.Parse(Console.ReadLine());
                var lineTwo = int.Parse(Console.ReadLine());
                var result = GetMax(lineOne, lineTwo);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                var lineOne = char.Parse(Console.ReadLine());
                var lineTwo = char.Parse(Console.ReadLine());
                var result = GetMax(lineOne, lineTwo);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                var lineOne = Console.ReadLine();
                var lineTwo = Console.ReadLine();
                var result = GetMax(lineOne, lineTwo);
                Console.WriteLine(result);
            }

        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
    }
}
