using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication309
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal pricePerCap = new decimal();
            DateTime date = new DateTime();
            decimal capCaunt = new decimal();
            decimal daysInMonth = new decimal();
            List<decimal> total = new List<decimal>();

            for (int i = 0; i < n; i++)
            {
                pricePerCap = decimal.Parse(Console.ReadLine());
                date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                capCaunt = decimal.Parse(Console.ReadLine());
                daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                total.Add((daysInMonth * capCaunt) * pricePerCap);
            }

            foreach (var item in total)
            {
                Console.WriteLine("The price for the coffee is: ${0:f2}", item);
            }            
            Console.WriteLine($"Total: ${total.Sum():f2}");
        }
    }
}
