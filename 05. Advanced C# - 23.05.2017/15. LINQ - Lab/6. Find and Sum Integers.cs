using System;
using System.Linq;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .ToList();
            decimal number = 0m;
            decimal result = 0m;
            foreach (var word in words)
            {
                decimal.TryParse(word, out number);
                result += number;
            }
            if (result != 0)
            {
                Console.WriteLine("{0:f0}", result);
            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}
