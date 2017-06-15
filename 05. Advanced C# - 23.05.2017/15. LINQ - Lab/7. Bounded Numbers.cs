using System;
using System.Linq;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            nums.Where(n => n<=bounds.Max() && n >= bounds.Min()).ToList().ForEach(n => Console.Write(n +" "));
        }
    }
}
