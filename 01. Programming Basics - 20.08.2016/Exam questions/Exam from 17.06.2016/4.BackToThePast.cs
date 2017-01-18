using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication129
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var year = decimal.Parse(Console.ReadLine());
            var spent = money;
            var age = 18m;
            for (int i = 0; i <= year-1800; i++)
            {
                if (i % 2 == 0)
                {
                    spent -= 12000m;
                }
                else
                {
                    spent -=(12000m + age * 50m);
                }
                age++;
            }
            if (spent<0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(spent));
               
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", spent);
            }
        }
    }
}
