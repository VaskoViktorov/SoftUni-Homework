using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication299
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split().ToArray();

            string holder = nums[1];
            int nextNum = new int();
            BigInteger Result = new BigInteger();
            BigInteger number = BigInteger.Parse(nums[0]);
            BigInteger multiplier = BigInteger.Parse(nums[0]);

            for (int i = holder.Length - 1; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    multiplier *= number;
                }

                nextNum = int.Parse(holder.Substring((holder.Length - 1) - i, 1));

                Result += nextNum * multiplier;

                multiplier = number;
            }

            Result += int.Parse(holder.Substring(holder.Length - 1, 1));

            Console.WriteLine(Result);
        }
    }
}
