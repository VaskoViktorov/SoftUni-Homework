using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var rate = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine());
            var lasagnaPrice = decimal.Parse(Console.ReadLine());
            var sandwichPrice = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = decimal.Parse(Console.ReadLine());
            var lasagnaQuantity = decimal.Parse(Console.ReadLine());
            var sandwichQuantity = decimal.Parse(Console.ReadLine());

            var totalCost = (pizzaPrice * pizzaQuantity + sandwichPrice * sandwichQuantity + lasagnaPrice * lasagnaQuantity) / rate;
            var change = money - totalCost;
            var leftover = Math.Abs(change);

            if (money > totalCost)
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", leftover);
            else
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", leftover);

        }
    }
}
