using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication213
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            decimal side = decimal.Parse(Console.ReadLine());
            string formula = Console.ReadLine();

            //invoke GetCubeFormulas
            if (formula == "face")
            {
                Console.WriteLine("{0:f2}", GetCubeFace(side));
            }
            else if (formula == "space")
            {
                Console.WriteLine("{0:f2}", GetCubeSpace(side));
            }
            else if (formula == "volume")
            {
                Console.WriteLine("{0:f2}", GetCubeVolume(side));
            }
            else if (formula == "area")
            {
                Console.WriteLine("{0:f2}", GetCubeArea(side));
            }
        }

        static decimal GetCubeFace(decimal side)
        {
            decimal face = (decimal)Math.Sqrt(2 * (double)side * (double)side);
            return face;

        }

        static decimal GetCubeSpace(decimal side)
        {
            decimal space = (decimal)Math.Sqrt(3 * (double)side * (double)side);
            return space;
        }

        static decimal GetCubeVolume(decimal side)
        {
            decimal volume = side * side * side;
            return volume;
        }

        static decimal GetCubeArea(decimal side)
        {
            decimal area = 6 * side * side;
            return area;
        }
    }
}
