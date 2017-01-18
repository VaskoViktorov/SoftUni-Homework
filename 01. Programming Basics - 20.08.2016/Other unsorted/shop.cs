using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var rightone = 0.00;
            city = city.ToLower();
            product = product.ToLower();


            if (city == "sofia")
            {
                if (product =="coffee")
                    rightone = 0.50;

                else if 
                    (product == "water")
                    rightone = 0.80;

                else if
                    (product == "beer")
                    rightone = 1.20;

                else if
                    (product == "sweets")
                    rightone = 1.45;

                else if
                    (product == "peanuts")
                    rightone = 1.60;
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                    rightone = 0.40;

                else if
                    (product == "water")
                    rightone = 0.70;

                else if
                    (product == "beer")
                    rightone = 1.15;

                else if
                    (product == "sweets")
                    rightone = 1.30;

                else if
                    (product == "peanuts")
                    rightone = 1.50;
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                    rightone = 0.45;

                else if
                    (product == "water")
                    rightone = 0.70;

                else if
                    (product == "beer")
                    rightone = 1.10;

                else if
                    (product == "sweets")
                    rightone = 1.35;

                else if
                    (product == "peanuts")
                    rightone = 1.55;
            }
            Console.WriteLine(rightone * quantity);
        }
    }
}
