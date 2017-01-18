using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var x1 = 0;
            var x2 = 3 * h;
            var y1 = h;
            var y2 = 0;
            var z1 = h;
            var c1 = 4 * h;
            var z2 = 2 * h;
            var c2 = h;

            if (x > x1 + h && x < x2 - h && y1 == y)
                Console.WriteLine("inside");
            else if (x == x1 && x <= x2 && y <= y1 && y >= y2 || x == z1 && x <= z2 && y >= c2 && y <= c1)
                Console.WriteLine("border");
            else if (x >= x1 && x == x2 && y <= y1 && y >= y2 || x >= z1 && x == z2 && y >= c2 && y <= c1)
                Console.WriteLine("border");
            else if (x >= x1 && x <= x2 && y == y1 && y >= y2 || x >= z1 && x <= z2 && y == c2 && y <= c1)
                Console.WriteLine("border");
            else if (x >= x1 && x <= x2 && y <= y1 && y == y2 || x >= z1 && x <= z2 && y >= c2 && y == c1)
                Console.WriteLine("border");
            else if (x > x1 && x < x2 && y < y1 && y > y2 || x > z1 && x < z2 && y > c2 && y < c1)
                Console.WriteLine("inside");

            else
                Console.WriteLine("outside");


        }

    }
}
