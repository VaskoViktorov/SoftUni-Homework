using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication234
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] arry1 = Console.ReadLine().Split(' ');
            string[] arry2 = Console.ReadLine().Split(' ');

            //Reverse input
            string[] revArry1 = (arry1.Reverse()).ToArray();
            string[] revArry2 = (arry2.Reverse()).ToArray();

            //Invoke counters from right to left and from left ot right.
            var result = Math.Max(Arrays(arry1, arry2), RevArrays(revArry1, revArry2));

            //Print result.
            Console.WriteLine($"{result}");

        }

        static int Arrays(string[] arry1, string[] arry2)
        {
            int counterFromRight = 0;
            for (int i = 0; i < Math.Min(arry1.Length, arry2.Length); i++)
            {
                if (arry1[i] == arry2[i])
                {
                    counterFromRight++;
                }
                else
                {
                    break;
                }
            }
            return counterFromRight;
        }

        static int RevArrays(string[] revArry1, string[] revArry2)
        {
            int counterFromLeft = 0;

            for (int i = 0; i < Math.Min(revArry1.Length, revArry2.Length); i++)
            {
                if (revArry1[i] == revArry2[i])
                {
                    counterFromLeft++;
                }
                else
                {
                    break;
                }
            }
            return counterFromLeft;

        }
    }
}
