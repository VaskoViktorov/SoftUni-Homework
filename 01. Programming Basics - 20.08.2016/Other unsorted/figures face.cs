using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var first = double.Parse(Console.ReadLine());
           

            if (type == "square")
                Console.WriteLine("{0:f3}",(first *first));

            else if (type == "circle")
                Console.WriteLine("{0:f3}",first * first * Math.PI);

            else if (type == "rectangle")
            {
             var  second = double.Parse(Console.ReadLine());
                {
                    Console.WriteLine("{0:f3}",first * second);
                }
            }
            else if (type == "triangle")
            {
                var second = double.Parse(Console.ReadLine());
                {
                    Console.WriteLine("{0:f3}",0.5 * first * second);
                }
            }


        }
    }
}
