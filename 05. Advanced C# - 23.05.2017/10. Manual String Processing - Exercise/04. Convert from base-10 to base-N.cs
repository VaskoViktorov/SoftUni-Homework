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
            BigInteger[] nums = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            StringBuilder result = new StringBuilder();
            BigInteger holder = nums[1];
            BigInteger left = nums[1];
            while (true)
            {
                if (holder >= nums[0])
                {

                    holder %= nums[0];
                    left /= nums[0];

                    result.Append(holder);
                    holder = left;


                }
                else
                {
                    result.Append(holder);
                    break;
                }

            }

            var result1 = new StringBuilder();

            for (int i = result.Length-1; i>= 0 ; i--)
            {
                result1.Append(result[i]);
            }

            Console.WriteLine(result1);
        }
    }
}
