using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication163
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Length: ");

            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            double V = double.Parse(Console.ReadLine());

            double Volume = (lenght * width * V) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", Volume);


        }
    }
}
