using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {

            var day = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c   = double.Parse(Console.ReadLine());
            var price = 0.0;
            switch (day)
            {
                case "Premiere": price = 12; Console.WriteLine("{0:f2} leva",price * (r * c)); break;
                case "Normal": price = 7.5; Console.WriteLine("{0:f2} leva", price * (r * c)); break;
                case "Discount": price = 5; Console.WriteLine("{0:f2} leva", price * (r * c)); break;

                default: Console.WriteLine("unknown"); break;
            }
        }
        }
    }
