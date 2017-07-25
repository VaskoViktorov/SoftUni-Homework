using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Generic_Box
{
   public class StartUp
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            List<Box<double>> listOfBoxes = new List<Box<double>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<double> boxStr = new Box<double>(double.Parse(Console.ReadLine()));
                listOfBoxes.Add(boxStr);
            }

            double element = double.Parse(Console.ReadLine());
            int result = GetGreaterElementsCount(listOfBoxes, element);

            Console.WriteLine(result);
        }

        public static int GetGreaterElementsCount<T>(List<Box<T>> listOfBoxes, T element)
            where T : IComparable<T>
        {
            return listOfBoxes.Count(b => b.Value.CompareTo(element) > 0);

        }
    }
}

