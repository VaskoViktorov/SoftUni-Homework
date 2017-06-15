using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication368
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> carPlates = new SortedSet<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                
                string[] car = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (car[0] == "IN")
                {
                    carPlates.Add(car[1]);
                }
                else if (car[0] == "OUT")
                {
                    carPlates.Remove(car[1]);
                }
                input = Console.ReadLine();
            }
            if (carPlates.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var carPlate in carPlates)
                {
                    Console.WriteLine(carPlate);
                }
            }

        }
    }
}
