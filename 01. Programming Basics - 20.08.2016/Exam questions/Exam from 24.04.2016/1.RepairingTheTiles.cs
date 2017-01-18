using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication119
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());
            var size = n * n - m * o;
            var plochki = size / (w * l);
            var time = plochki * 0.2;
            Console.WriteLine(plochki);
            Console.WriteLine(time);
        }
    }
}
