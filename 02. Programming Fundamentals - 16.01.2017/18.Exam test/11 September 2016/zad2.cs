using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication330
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] items = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int entry = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string priceRate = Console.ReadLine();
            long entryCost = items[entry];

            for (int i = 0; i < items.Length; i++)
            {
                if (i == entry)
                {
                    continue;
                }
                if (type == "cheap")
                {
                    if (items[i] >= entryCost)
                    {
                        items[i] = 0;
                    }
                }
                else
                {
                    if (items[i] < entryCost)
                    {
                        items[i] = 0;
                    }
                }

                if (priceRate == "positive")
                {
                    if (items[i] < 0)
                    {
                        items[i] = 0;
                    }
                }
                else if (priceRate == "negative")
                {
                    if (items[i] > 0)
                    {
                        items[i] = 0;
                    }
                }                
            }

            long rightSide = items.Skip(entry + 1).Take(items.Length - (entry + 1)).ToArray().Sum();
            long leftSide = items.Take(entry).ToArray().Sum();
            if (leftSide >= rightSide)
                Console.WriteLine($"Left - {leftSide}");
            else
                Console.WriteLine($"Right - {rightSide}");
        }


    }
}

