using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();           
            int[][] matrix = new int[num[0]][];
            long sum = 0;

            for (int row = 0; row < num[0]; row++)
            {
                int[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = input;

                foreach (var number in matrix[row])
                {
                    sum += number;
                }
            }
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(sum);

        }
    }
}
