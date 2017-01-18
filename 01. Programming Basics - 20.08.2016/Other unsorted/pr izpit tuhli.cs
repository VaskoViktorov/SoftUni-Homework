using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication69
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var x = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            double turns = w * m;

            Console.WriteLine(Math.Ceiling(x / turns)); 
        }
    }
}
