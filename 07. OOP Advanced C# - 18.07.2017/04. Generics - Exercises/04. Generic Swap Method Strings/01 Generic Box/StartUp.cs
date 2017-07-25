﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Generic_Box
{
   public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            List<Box<string>> listOfBoxes = new List<Box<string>>();

            for (int i = 0; i < num; i++)
            {
                Box<string> boxStr = new Box<string>(Console.ReadLine());
                listOfBoxes.Add(boxStr);
            }

            var indexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            SwapElements(listOfBoxes, indexes[0], indexes[1]);

            foreach (var box in listOfBoxes)
            {
                Console.WriteLine(box);
            }
        }

        private static void SwapElements<T>(List<T> listOfBoxes, int index1, int index2)
        {
            T tempBox = listOfBoxes[index1];
            listOfBoxes[index1] = listOfBoxes[index2];
            listOfBoxes[index2] = tempBox;
        }
    }
}
