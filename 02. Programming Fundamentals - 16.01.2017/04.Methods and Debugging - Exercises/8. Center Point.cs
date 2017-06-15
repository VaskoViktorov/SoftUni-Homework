using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication211
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());

            //Invoke CordinateCenter
            decimal NearCenter = CordinateCenter(x1, y1, x2, y2);

            //Print
            if (NearCenter == 1)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static decimal CordinateCenter(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            decimal nearest = 0;
            decimal x1y1 = 1;
            decimal x2y2 = 2;

            if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
            {
                nearest = x2y2;
                return nearest;
            }
            else
            {
                nearest = x1y1;
                return nearest;
            }

        }
    }
}
