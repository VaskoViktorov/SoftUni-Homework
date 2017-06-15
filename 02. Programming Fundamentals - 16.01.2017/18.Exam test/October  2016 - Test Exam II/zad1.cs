using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication314
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bananas = decimal.Parse(Console.ReadLine());
            decimal eggs = decimal.Parse(Console.ReadLine());
            decimal berries = decimal.Parse(Console.ReadLine());

            decimal portions = Math.Ceiling(guests / 6m);

            decimal bananaIngridient = 2m * portions;
            decimal eggIngridient = 4m * portions;
            decimal berieIngridient = 0.2m * portions;
            decimal recepie =  (bananaIngridient * bananas + eggIngridient * eggs + berieIngridient * berries);
            decimal neededCash = cash - recepie;
            if (neededCash >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {recepie:f2}lv.");

            }
            else if (neededCash < 0)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(neededCash):f2}lv more.");
            }



        }
    }
}
