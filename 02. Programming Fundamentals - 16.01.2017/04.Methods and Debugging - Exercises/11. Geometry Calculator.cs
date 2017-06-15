using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication214
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string figure =   Console.ReadLine();
            decimal sideA = decimal.Parse( Console.ReadLine());
            
             //Invoce figure formula
            if (figure == "triangle")
            {
                decimal sideB = decimal.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}",GetTriangleArea(sideA,sideB));
            }
           else if (figure == "square")
            {

                Console.WriteLine("{0:f2}", GetSquareArea(sideA));
            }
            else if (figure == "rectangle")
            {
                decimal sideB = decimal.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetRectangleArea(sideA,sideB));
            }
            else if (figure == "circle")
            {

                Console.WriteLine("{0:f2}", GetCircleArea(sideA));
            }

        }

        static decimal GetTriangleArea(decimal side, decimal height)
        {
            decimal triangleArea =(side*height)*(1m/2m);
            return triangleArea;
        }

        static decimal GetSquareArea(decimal side)
        {
            decimal squareArea = side*side;
            return squareArea;
        }

        static decimal GetRectangleArea(decimal width, decimal height)
        {
            decimal rectangleArea = width * height;
            return rectangleArea;
        }

        static decimal GetCircleArea(decimal radius)
        {
            decimal circleArea = (decimal)(Math.PI * (double)radius * (double)radius);
            return circleArea;
        }
    }
}
