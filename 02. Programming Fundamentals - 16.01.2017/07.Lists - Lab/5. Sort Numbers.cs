using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication252
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            list.Sort();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
