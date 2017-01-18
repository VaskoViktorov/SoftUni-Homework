using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication128
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var category =    Console.ReadLine();
            var pers = decimal.Parse(Console.ReadLine());
            var VIP = 499.99m;
            var Normal = 249.99m;
            var money = 0m;
            var tickets = 0m;
            var sum = 0m;
            if (pers <= 4 & pers > 0)
            {
                money = budget - (budget * 0.75m);
            }
            else if (pers >= 5 & pers <= 9)
            {
                money = budget - (budget * 0.6m);
            }
            else if (pers >= 10 & pers <= 24)
            {
                money = budget - (budget * 0.5m);
            }
            else if (pers >= 25 & pers <= 49)
            {
                money = budget - (budget * 0.4m);
            }
            else if (pers >= 50)
            {
                money = budget - (budget * 0.25m);
            }
            if (category == "VIP")
            {
                tickets = pers* VIP;
                sum = money - tickets;
            }
            else
            {
                tickets = pers*Normal;
                sum = money - tickets;
            }
            if(sum>0)
                Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
            else
                Console.WriteLine("Not enough money! You need {0:f2} leva.",tickets-money);
        }
    }
}
