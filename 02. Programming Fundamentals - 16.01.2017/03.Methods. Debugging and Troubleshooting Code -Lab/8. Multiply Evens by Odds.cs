using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication201
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSumOfOddAndEven(num));
        }
        private static int GetSumOfOddAndEven(int n)
        {
            int sumOfEven = GetSumEven(n);
            int sumOfOdd = GetSumOdd(n);
            return sumOfOdd * sumOfEven;
        }

        static int GetSumEven(int n)
        {
            int sumOfEven = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = Math.Abs(n) % 10;
                if (lastDigit % 2 == 0)
                {
                    sumOfEven += lastDigit;
                }
                n /= 10;
            }
            return sumOfEven;

        }

        static int GetSumOdd(int n)
        {
            int sumOfOdd = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = Math.Abs(n) % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOfOdd += lastDigit;
                }
                n /= 10;
            }
            return sumOfOdd;
        }
    }
}
