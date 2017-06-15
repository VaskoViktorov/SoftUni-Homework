using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication341
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal USPrice = decimal.Parse(Console.ReadLine());
            decimal USweight = decimal.Parse(Console.ReadLine());
            decimal UKPrice = decimal.Parse(Console.ReadLine());
            decimal UKweight = decimal.Parse(Console.ReadLine());
            decimal CHPrice = decimal.Parse(Console.ReadLine());
            decimal CHweight = decimal.Parse(Console.ReadLine());

            USPrice = (USPrice / 0.58m)/USweight;
            UKPrice = (UKPrice / 0.41m) / UKweight;
            CHPrice = (CHPrice * 0.27m) / CHweight;
            
            decimal minPrice = Math.Min(Math.Min(USPrice, UKPrice),CHPrice);
            decimal maxPrice = Math.Max(Math.Max(USPrice, UKPrice), CHPrice);
            if (minPrice.Equals(USPrice))
            {
                Console.WriteLine($"US store. {USPrice:f2} lv/kg");
            }
            else if (minPrice.Equals(UKPrice))
            {
                Console.WriteLine($"UK store. {UKPrice:f2} lv/kg");
            }
            else
            {
                Console.WriteLine($"Chinese store. {CHPrice:f2} lv/kg");
            }
            Console.WriteLine($"Difference {(maxPrice-minPrice):f2} lv/kg");
        }
    }
}
