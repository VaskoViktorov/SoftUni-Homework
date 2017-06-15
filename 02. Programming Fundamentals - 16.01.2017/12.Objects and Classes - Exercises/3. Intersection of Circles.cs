using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication283
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = ReadInput();
            Circle c2 = ReadInput();

            Console.WriteLine(CalcDistance(c1, c2));
        }
        static Circle ReadInput()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle a = new Circle();
            a.X = input[0];
            a.Y = input[1];
            a.R = input[2];
            return a;
        }
        static string CalcDistance(Circle c1, Circle c2)
        {
            int deltaX = c2.X - c1.X;
            int deltaY = c2.Y - c1.Y;
            var areaC1 = Math.PI * c1.R;
            var areaC2 = Math.PI * c2.R;
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (c1.R + c2.R >= distance)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

    }
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }
}
