using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication73
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            day += 5;
            if (month == 02 || month == 2)
            {
                if (day > 28)
                {
                    day = day - 28;
                    month += 1;
                }
            }
            else if (month == 4 || month == 04 || month == 6 || month == 06 || month == 9 || month == 09 || month == 11)
            {
                if (day > 30)
                {
                    day = day - 30;
                    month += 1;
                }
            }
            else

            {
                if (day > 31)
                {
                    day = day - 31;
                    month += 1;
                }
            }
               
            if (month > 12)
            {
                month = month - 12;
            }
            Console.WriteLine("{0}.{1:00}",day,month);
        }
    }
}
