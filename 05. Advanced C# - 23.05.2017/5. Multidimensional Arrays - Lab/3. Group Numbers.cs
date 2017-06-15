using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[3][];
            Queue<int> zero = new Queue<int>();
            Queue<int> one = new Queue<int>();
            Queue<int> two = new Queue<int>();

            foreach (var num in nums)
            {
                if (num % 3 == 0)
                {
                    zero.Enqueue(num);
                }
                if (num % 3 == 1 || num % 3 == -1)
                {
                   one.Enqueue(num);
                }
                if (num % 3 == 2 || num % 3 == -2)
                {
                    two.Enqueue(num);
                }
            }

            matrix[0] = zero.ToArray();
            matrix[1] = one.ToArray();
            matrix[2] = two.ToArray();

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}
