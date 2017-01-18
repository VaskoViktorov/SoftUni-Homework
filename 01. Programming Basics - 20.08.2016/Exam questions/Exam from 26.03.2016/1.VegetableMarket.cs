using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication113
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVeg = decimal.Parse(Console.ReadLine());
            var priceFruit = decimal.Parse(Console.ReadLine());
            var kgVeg = decimal.Parse(Console.ReadLine());
            var kgFruit = decimal.Parse(Console.ReadLine());

            var total = (priceVeg * kgVeg + priceFruit * kgFruit) / 1.94m;
            Console.WriteLine(total);
        }
    }
}
