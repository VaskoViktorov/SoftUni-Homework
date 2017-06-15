using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication241
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int newLength = 1;
            int bestStart = 0;
            int bestLength = 0;
            int startPoint = 0;
               
            // define best lenght and start point         
            for (int i = 1; i <= array.Length - 1; i++)
            {

                if (array[i - 1] == array[i])
                {
                    newLength++;
                    if (newLength > bestLength)
                    {
                       
                        bestLength = newLength;
                        bestStart = startPoint;
                    }                                       
                }

                else
                {
                    newLength = 1;
                    startPoint = i;
                }
            }

            for (int i = 0; i < bestLength; i++)
            {              
                    Console.Write($"{array[bestStart+i]} ");                                                  
            }
        }
    }
}
