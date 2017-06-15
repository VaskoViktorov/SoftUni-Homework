using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication227
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            decimal[] realNum = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            int[] num = new int[realNum.Length];

            //from real numbers to whole numbers
            for (int i = 0; i < realNum.Length; i++)
            {
                num[i] = (int)Math.Round(realNum[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{realNum[i]} => {num[i]}");
            }
        }
    }
}
