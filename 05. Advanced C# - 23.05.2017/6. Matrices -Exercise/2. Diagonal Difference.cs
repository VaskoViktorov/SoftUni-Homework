using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] matrix = new int[num][];
            int rightDiagonal = 0;
            int leftDiagonal = 0;
                           
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] {' ','\n', '\t'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();      
                rightDiagonal += matrix[row][row];
                leftDiagonal += matrix[row][matrix.Length-1 - row];

            }
            Console.WriteLine(Math.Abs(rightDiagonal-leftDiagonal));
          
        }
    }
}
