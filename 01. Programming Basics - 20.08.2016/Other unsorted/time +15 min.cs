using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            if (min + 15 >= 60 && hour <= 23)
            {
                hour += 1;
                min -= 45;

                if (hour == 24)
                    hour -= 24;
            }
            else if (hour > 24)
            {
                hour %= 24;

                min += 15;
            }
            else
                min += 15;

            Console.WriteLine("{0}:{1:00}", hour, min);
        }
    }
}
