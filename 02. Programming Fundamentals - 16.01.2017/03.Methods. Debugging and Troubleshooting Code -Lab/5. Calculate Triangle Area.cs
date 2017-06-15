using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication198
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, heigh);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double heigh)
        {
            return width * heigh / 2;
        }
    }
}
