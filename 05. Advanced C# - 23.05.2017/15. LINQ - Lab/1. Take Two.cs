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
                .Select(int.Parse)
                .ToList();

            nums.Where(n => 10 <= n && n <= 20)
                .Distinct()
                .Take(2)
                .ToList()
                .ForEach(n => Console.Write(n + " "));
        }
    }
}