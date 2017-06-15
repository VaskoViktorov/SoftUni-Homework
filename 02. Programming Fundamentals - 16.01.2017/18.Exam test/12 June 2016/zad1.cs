using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication334
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            decimal avr = nums.Average();
            nums = nums.OrderByDescending(x => x).ToArray();
            List<decimal> topNums = new List<decimal>();
            bool succses = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > avr && topNums.Count < 5)
                {
                    topNums.Add(nums[i]);
                    succses = true;
                }
            }
            if (succses == true)
            {
                Console.WriteLine(string.Join(" ", topNums));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
