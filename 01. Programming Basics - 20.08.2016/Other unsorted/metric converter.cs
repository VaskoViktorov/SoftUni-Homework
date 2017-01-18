using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var enter = Console.ReadLine();
            var exit = Console.ReadLine();

            if (enter == "mm")
                num /= 1000;

            else if (enter == "cm")
                num /= 100;

            else if (enter == "mi")
                num /= 0.000621371192;

            else if (enter == "in")
                num /= 39.3700787;

            else if (enter == "km")
                num /= 0.001;

            else if (enter == "ft")
                num /= 3.2808399;

            else if (enter == "yd")
                num /= 1.0936133;

            if (exit == "mm")
                num *= 1000;

            else if (exit == "cm")
                num *= 100;

            else if (exit == "mi")
                num *= 0.000621371192;

            else if (exit == "in")
                num *= 39.3700787;

            else if (exit == "km")
                num *= 0.001;

            else if (exit == "ft")
                num *= 3.2808399;

            else if (exit == "yd")
                num *= 1.0936133;

            Console.WriteLine("{0} {1}",num,exit);
        }
    }
}
