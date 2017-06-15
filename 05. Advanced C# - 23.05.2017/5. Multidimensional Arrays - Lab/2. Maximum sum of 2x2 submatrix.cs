using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[num[0]][];
            int maxRow = 0;
            int maxCol = 0;
            int maxSum = int.MinValue;

            for (int row = 0; row < num[0]; row++)
            {
                int[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = input;              
            }

            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] +matrix[row + 1][col + 1];
                    if (currentSum > maxSum)
                    {
                        maxRow = row;
                        maxCol = col;
                        maxSum = currentSum;
                    }

                }
            }
            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol+1]}\n{matrix[maxRow+1][maxCol]} {matrix[maxRow+1][maxCol+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
