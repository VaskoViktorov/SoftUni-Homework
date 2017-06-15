using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication338
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalWater = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            long maxCapacity = long.Parse(Console.ReadLine());
            List<int> emptyBottles = new List<int>();
            double waterNeeded = maxCapacity * bottles.Length - bottles.Sum();

            if (waterNeeded <= totalWater)
            {
                Console.WriteLine($"Enough water!");
                Console.WriteLine("Water left: {0}l.", totalWater - waterNeeded);
            }
            else
            {
                if (totalWater % 2 == 1)
                {

                    for (int i = bottles.Length - 1; i >= 0; i--)
                    {

                        totalWater -= (maxCapacity - bottles[i]);

                        if (totalWater < 0)
                        {
                            emptyBottles.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= bottles.Length - 1; i++)
                    {

                        totalWater -= (maxCapacity - bottles[i]);

                        if (totalWater < 0)
                        {
                            emptyBottles.Add(i);
                        }
                    }
                }
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {emptyBottles.Count}");
                Console.WriteLine("With indexes: {0}", string.Join(", ", emptyBottles));
                Console.WriteLine($"We need {Math.Abs(totalWater)} more liters!");
            }
        }
    }
}
