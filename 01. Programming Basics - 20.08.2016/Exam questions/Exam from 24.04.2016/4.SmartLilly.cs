using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication122
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = decimal.Parse(Console.ReadLine());
            var price = decimal.Parse(Console.ReadLine());
            var toyPrice = decimal.Parse(Console.ReadLine());
            var oddAge = 0m;
            var evenAge = 0m;
            var saved = 0m;
            var toys = 0m;
            var stolen = 0m;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    stolen += 1;
                    evenAge += 10m;
                    saved += evenAge ;
                }
                else
                    oddAge += 1;
                    

            }
            toys = oddAge * toyPrice;
            var total = saved + toys - stolen;
            if (total>=price)
            Console.WriteLine("Yes! {0:f2}",total-price);
            else
                Console.WriteLine("No! {0:f2}", price-total);
        }
    }
}
