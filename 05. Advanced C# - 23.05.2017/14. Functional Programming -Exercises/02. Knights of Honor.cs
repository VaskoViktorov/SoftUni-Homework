using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Action<string> action = x =>
            {
                x.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList()
                    .ForEach(t => Console.WriteLine($"Sir {t}"));
            };

            action(input);
        }
    }
}
