using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication337
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal adults = new decimal();
            decimal adultsTicket = new decimal();
            decimal young = new decimal();
            decimal youngTicket = new decimal();
            decimal FuelPrice = new decimal();
            decimal FuelConsupsion = new decimal();
            decimal FlightDuration = new decimal();
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            decimal profit = new decimal();

            for (int i = 0; i < num; i++)
            {
                adults = decimal.Parse(Console.ReadLine());
                adultsTicket = decimal.Parse(Console.ReadLine());
                young = decimal.Parse(Console.ReadLine());
                youngTicket = decimal.Parse(Console.ReadLine());
                FuelPrice = decimal.Parse(Console.ReadLine());
                FuelConsupsion = decimal.Parse(Console.ReadLine());
                FlightDuration = decimal.Parse(Console.ReadLine());

                profit = (adults * adultsTicket + young * youngTicket) - (FuelPrice * FuelConsupsion * FlightDuration);

                if (profit >= 0)
                {
                    result.Add($"You are ahead with {profit:f3}$.", profit);

                }
                else if (profit < 0)
                {
                    result.Add($"We've got to sell more tickets! We've lost {profit:f3}$.", profit);
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine($"Overall profit -> {result.Values.Sum():f3}$.");
            Console.WriteLine($"Average profit -> {result.Values.Average():f3}$.");



        }
    }
}
