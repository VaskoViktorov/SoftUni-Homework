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
            int number = int.Parse(Console.ReadLine());

            int total = 0;
            int currentNumber = 0;
            bool reason = false;

            for (int i = 1; i <= number; i++)
            {
                currentNumber = i;

                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }

                reason = (total == 5) || (total == 7) || (total == 11);

                Console.WriteLine($"{currentNumber} -> {reason}");
                total = 0;
                i = currentNumber;
            }
        }
    }
}
