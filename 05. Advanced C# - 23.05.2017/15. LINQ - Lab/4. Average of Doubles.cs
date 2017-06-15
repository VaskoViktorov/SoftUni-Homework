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
            var words = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();


            Console.WriteLine("{0:f2}", words.Average());
           
        }
    }
}
