using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication101
{
    class Program
    {
        static void Main(string[] args)
        {
            var attempts = int.Parse(Console.ReadLine());
            long thievesTotal = 0;
            long slapped = 0;
            long beersTotal = 0;
            for (int i = 1; i <= attempts; i++)
            {
                var thieves = int.Parse(Console.ReadLine());
                var beers = int.Parse(Console.ReadLine());
                thievesTotal +=thieves;
                if (thieves >= 5)
                {
                    slapped += 5;
                }
                else
                {
                    slapped = slapped + thieves;
                }
                beersTotal +=beers;
                
            }
           
            Console.WriteLine("{0} thieves slapped.",slapped);
            Console.WriteLine("{0} thieves escaped.",thievesTotal-slapped);
            Console.WriteLine("{0} packs, {1} bottles.",beersTotal/6,beersTotal%6);
        }
    }
}
