using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication64
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0m;

            while (true)
            {
                Console.Write("Enter even number: ");
                try
                {
                    n = decimal.Parse(Console.ReadLine());

                    if (n % 2m == 0m)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even");
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
            }

            Console.WriteLine("Even number etered:{0}", n);



        }
    }
}
