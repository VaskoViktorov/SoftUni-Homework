using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication127
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqare = double.Parse(Console.ReadLine());
            var grapem3 = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());

            var grapetotal = ((sqare * grapem3 )* 0.4)/2.5;
            if (wine > grapetotal)
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wine - grapetotal));
            else if (wine <= grapetotal)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(grapetotal));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(grapetotal - wine), Math.Ceiling((grapetotal - wine) / workers));
            }
        }
    }
}
