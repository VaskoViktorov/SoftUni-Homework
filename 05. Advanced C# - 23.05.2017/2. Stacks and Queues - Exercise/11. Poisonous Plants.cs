using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication385
{
    class Program
    {
        public static void Main(string[] args)
        {
            int plantsNumber = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var daysPlantsDie = new int[plantsNumber];
            var previousPlants = new Stack<int>();
            previousPlants.Push(0);

            for (int i = 1; i < plantsNumber; i++)
            {
                int lastDay = 0;
                while (previousPlants.Count() > 0 && plants[previousPlants.Peek()] >= plants[i])
                {
                    lastDay = Math.Max(lastDay, daysPlantsDie[previousPlants.Pop()]);
                }

                if (previousPlants.Count() > 0)
                {
                    daysPlantsDie[i] = lastDay + 1;
                }
                previousPlants.Push(i);
            }

            Console.WriteLine(daysPlantsDie.Max());
        }
    }
}
