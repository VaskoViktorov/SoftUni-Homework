using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication263
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
