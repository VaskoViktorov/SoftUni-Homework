using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication335
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            decimal pricePerCap = new decimal();
            DateTime time = new DateTime();
            decimal capCount = new decimal();
            List<decimal> total = new List<decimal>();
            decimal orderPrice = new decimal();
           
            for (int i = 0; i < orders; i++)
            {
                pricePerCap = decimal.Parse(Console.ReadLine());
                time = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                capCount = decimal.Parse(Console.ReadLine());

                orderPrice =  DateTime.DaysInMonth(time.Year, time.Month )*capCount*pricePerCap;
                total.Add(orderPrice);
            }
        
            foreach (var order in total)
            {
                Console.WriteLine($"The price for the coffee is: ${order:f2}");
            }
            Console.WriteLine($"Total: ${total.Sum():f2}");
        }
    }
}
