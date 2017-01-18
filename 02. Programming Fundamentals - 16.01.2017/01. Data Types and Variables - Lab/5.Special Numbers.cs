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
            int numbers = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;
            var realsum = 0;
            for (int i = 1; i < numbers + 1; i++)
            {
                sum = i % 10;
                count += sum;
                realsum = i - i % 10;
                while (realsum > 0)
                {
                    realsum = realsum / 10;
                    count += realsum;
                }
                if (count == 5 || count == 7 || count == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                count = 0;



            }
        }
    }
}
