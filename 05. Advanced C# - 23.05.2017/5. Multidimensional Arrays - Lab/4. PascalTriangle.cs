using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            long[][] matrix = new long[input][];

            for (int i = 0; i < input; i++)
            {
                matrix[i] = new long[i + 1];
                matrix[i][0] = 1;
                matrix[i][matrix[i].Length - 1] = 1;

                for (int j = 1; j < matrix[i].Length - 1; j++)
                {
                    matrix[i][j] = matrix[i-1][j-1] + matrix[i-1][j];
                }

                Console.WriteLine(string.Join(" ", matrix[i]));
            }         
        }
    }
}
