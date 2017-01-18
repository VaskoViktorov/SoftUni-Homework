using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication107
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            var sum = 0d;

            if (n >= 100)
                sum = 0.06 * n;
            else if (n >= 20)
                sum = 0.09 * n;
            else if (n < 20)
            {
                if (day == "day")
                {
                    sum = 0.7 + (0.79 * n);
                }
                else if (day == "night")
                {
                    sum = 0.7 + (0.9 * n);
                }
            }
            Console.WriteLine("{0}", sum);
        }

    }
}

