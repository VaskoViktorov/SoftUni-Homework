using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var type = 0.0;

            if (quantity >= 0 && quantity <= 500)

                switch (city)
                {
                    case "Sofia": type = 0.05; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Varna": type = 0.045; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Plovdiv": type = 0.055; Console.WriteLine("{0:f2}", type * quantity); break;
                    default: Console.WriteLine("error"); break;
                }

            else if (quantity >= 500 && quantity <= 1000)

                switch (city)
                {
                    case "Sofia": type = 0.07; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Varna": type = 0.075; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Plovdiv": type = 0.08; Console.WriteLine("{0:f2}", type * quantity); break;
                    default: Console.WriteLine("error"); break;
                }

            else if (quantity >= 1000 && quantity <= 10000)

                switch (city)
                {
                    case "Sofia": type = 0.08; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Varna": type = 0.1; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Plovdiv": type = 0.12; Console.WriteLine("{0:f2}", type * quantity); break;
                    default: Console.WriteLine("error"); break;
                }
            else if (quantity > 10000)

                switch (city)
                {
                    case "Sofia": type = 0.12; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Varna": type = 0.13; Console.WriteLine("{0:f2}", type * quantity); break;
                    case "Plovdiv": type = 0.145; Console.WriteLine("{0:f2}", type * quantity); break;
                    default: Console.WriteLine("error"); break;
                }
            else
                Console.WriteLine("error");
        }
    }
}