using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = double.Parse(Console.ReadLine());
            string daytime = Console.ReadLine();
            double taxiday = 0.79;
            double taxinight = 0.90;
            double bus = 0.09;
            double train = 0.06;
            double result = 0.0;

            if (time > 0 && time < 20)
            {
                if (daytime == "day")
                    result = time * taxiday + 0.70;
                else if (daytime == "night")
                    result = time * taxinight + 0.70;
                Console.WriteLine(result);

            }
            else if (time >= 20 && time < 100)
            {
                result = time * bus;
                Console.WriteLine(result);
            }
            else if (time >= 100)
            {
                result = time * train;
                Console.WriteLine(result);
            }



            else if (time == 0)
            {
                Console.WriteLine("0");
            }
            else
                Console.WriteLine("wrong value");







        }

    }
}
