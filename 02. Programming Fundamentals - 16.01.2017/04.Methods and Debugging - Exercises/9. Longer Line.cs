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
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal x3 = decimal.Parse(Console.ReadLine());
            decimal x4 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            decimal y3 = decimal.Parse(Console.ReadLine());
            decimal y4 = decimal.Parse(Console.ReadLine());


            //Invoke CordinateCenter
            decimal NearCenter = CordinateCenter(x1, x2, x3, x4, y1, y2, y3, y4);

            //Print
            if (NearCenter == 1)
            {
                if (Math.Abs(x1) + Math.Abs(x2) > Math.Abs(x3) + Math.Abs(x4))
                {
                    Console.WriteLine($"({x3}, {x4})({x1}, {x2})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {x2})({x3}, {x4})");
                }

            }
            else
            {
                if (Math.Abs(y1) + Math.Abs(y2) > Math.Abs(y3) + Math.Abs(y4))
                {
                    Console.WriteLine($"({y3}, {y4})({y1}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({y1}, {y2})({y3}, {y4})");
                }

            }
        }

        static decimal CordinateCenter(decimal x1, decimal x2, decimal x3, decimal x4, decimal y1, decimal y2, decimal y3, decimal y4)
        {
            decimal nearest = 0;
            decimal x = 1;
            decimal y = 2;

            if (Math.Abs(x1) + Math.Abs(x2) + Math.Abs(x3) + Math.Abs(x4) > Math.Abs(y1) + Math.Abs(y2) + Math.Abs(y3) + Math.Abs(y4))
            {
                nearest = x;
                return nearest;
            }
            else
            {
                nearest = y;
                return nearest;
            }

        }
    }
}
