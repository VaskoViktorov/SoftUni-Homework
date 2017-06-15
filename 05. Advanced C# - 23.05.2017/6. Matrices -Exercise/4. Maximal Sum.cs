using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] matrix = new int[num[0]][];
            long optSum = long.MinValue;
            int optSumPointRow = 0;
            int optSumPointCol = 0;
            long sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            }

            for (int row = 0; row < matrix.Length - 2; row++)
            {

                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sum += matrix[row + i][col] + matrix[row + i][col+1] + matrix[row + i][col + 2];
                    }

                    if (sum > optSum)
                    {
                        optSum = sum;
                        optSumPointRow = row;
                        optSumPointCol = col;
                    }

                    sum = 0;
                }
            }

            Console.WriteLine($"Sum = {optSum}");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{matrix[optSumPointRow + i][optSumPointCol]} {matrix[optSumPointRow + i][optSumPointCol + 1]} {matrix[optSumPointRow + i][optSumPointCol + 2]}");               
            }
        }
    }
}
