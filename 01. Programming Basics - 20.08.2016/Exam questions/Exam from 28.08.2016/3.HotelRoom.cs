using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication134
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var days = decimal.Parse(Console.ReadLine());
            var studio = 0.0m;
            var apartment = 0.0m;
            if (days <= 7)
            {
                if (month == "May" || month == "October")
                {
                    studio = 50 * days;
                    apartment = 65 * days;
                }
                else if (month == "June" || month == "September")
                {
                    studio = 75.2m * days;
                    apartment = 68.7m * days;
                }
                else if (month == "July" || month == "August")
                {
                    studio = 76 * days;
                    apartment = 77 * days;
                }
            }
            else if (days > 7 & days <= 14)
            {

                if (month == "May" || month == "October")
                {
                    studio = (50 - 0.05m * 50m) * days;
                    apartment = 65 * days;
                }
                else if (month == "June" || month == "September")
                {
                    studio = 75.2m * days;
                    apartment = 68.7m * days;
                }
                else if (month == "July" || month == "August")
                {
                    studio = 76 * days;
                    apartment = 77 * days;
                }
            }
            else if (days > 14)
            {

                if (month == "May" || month == "October")
                {
                    studio = (50m - 0.3m * 50) * days;
                    apartment = (65m - 65m * 0.1m) * days;
                }
                else if (month == "June" || month == "September")
                {
                    studio = (75.2m - 75.2m * 0.2m) * days;
                    apartment = (68.7m - 68.7m * 0.1m) * days;
                }
                else if (month == "July" || month == "August")
                {
                    studio = 76 * days;
                    apartment = (77m - 77m * 0.1m) * days;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartment);
            Console.WriteLine("Studio: {0:f2} lv.", studio);
        }

    }
}
