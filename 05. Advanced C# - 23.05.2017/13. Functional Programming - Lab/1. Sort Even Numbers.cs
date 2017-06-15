using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            string first = Console.ReadLine();

            Func<string, List<long>> filther = x => x
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .Where(h => h % 2 == 0)
                .OrderBy(h => h)
                .ToList();

            Console.WriteLine(string.Join(", ", filther(first)));
        }
    }
}
