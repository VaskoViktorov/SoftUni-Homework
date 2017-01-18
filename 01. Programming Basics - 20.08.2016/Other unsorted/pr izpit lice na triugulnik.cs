using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var x1 = int.Parse(Console.ReadLine());
                var y1 = int.Parse(Console.ReadLine());
                var x2 = int.Parse(Console.ReadLine());
                var y2 = int.Parse(Console.ReadLine());
                var x3 = int.Parse(Console.ReadLine());
                var y3 = int.Parse(Console.ReadLine());

                var a = x2 - x3;
                var h = y1 - y3;
                var s = a * h / 2d;
                Console.WriteLine(Math.Abs(s));
            
        }
    }
}
