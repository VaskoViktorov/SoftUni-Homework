using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication97
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var diameter = int.Parse(Console.ReadLine());
            var planes = int.Parse(Console.ReadLine());
            var side1 = x + diameter;
            var side2 = y + diameter;
            var side3 = x - diameter;
            var side4 = y - diameter;

            for (int i = 0; i < planes; i++)
            {
                var xpl = int.Parse(Console.ReadLine());
                var ypl = int.Parse(Console.ReadLine());

                if (xpl <= side1 & ypl <= side2 & xpl >= side3 & ypl >= side4)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", xpl, ypl);
                }
            }

        }
    }
}
