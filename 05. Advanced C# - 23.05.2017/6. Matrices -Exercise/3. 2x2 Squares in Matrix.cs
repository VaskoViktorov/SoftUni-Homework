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
            string[][] matrix = new string[num[0]][];
            int equalSquares = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
               matrix[i] = Console.ReadLine().Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            }

            for (int row = 0; row < matrix.Length-1; row++)
            {
                
                for (int col = 0; col < matrix[row].Length -1; col++)
                {
                    string symbol = matrix[row][col];
                    if (matrix[row][col + 1] == symbol && matrix[row + 1][col] == symbol && matrix[row + 1][col + 1] == symbol)
                    {
                        equalSquares++;
                    }
                }
               
            }

            Console.WriteLine(equalSquares);
        }
    }
}
