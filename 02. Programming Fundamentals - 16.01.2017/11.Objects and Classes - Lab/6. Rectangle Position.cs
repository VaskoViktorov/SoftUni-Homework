using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication275
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle first = ReadPoint();
            Rectangle second = ReadPoint();

            string result = CalculateRectangleSize(first, second);
            Console.WriteLine(result);

        }

        static Rectangle ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle point = new Rectangle();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            point.Width = pointInfo[2]+point.X;
            point.Height = pointInfo[3]+ point.Y;
            return point;
        }
        static string CalculateRectangleSize(Rectangle first, Rectangle second)
        {

            if (first.X >= second.X && first.Y <= second.Y && first.Width <= second.Width && first.Height <= second.Height)
            {
                return "Inside";
            }
            else
            {
                return "Not inside";
            }
        }

    }

    class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
}
