using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .Where(n => Math.Abs(n)%2 == 0)
                .ToList();


            if (nums.Count != 0)
            {
                Console.WriteLine("{0:f2}", nums.Min());
            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}
