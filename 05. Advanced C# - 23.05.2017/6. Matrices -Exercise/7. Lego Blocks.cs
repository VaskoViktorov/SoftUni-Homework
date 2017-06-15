using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] matrix = new int[num][];
            int[][] revMatrix = new int[num][];
            int maxLength = 0;

            for (int i = 0; i < num; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            }

            for (int i = 0; i < num; i++)
            {
                char[] a = Console.ReadLine().ToCharArray();
                Array.Reverse(a);
                revMatrix[i] = string.Join("", a).Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }           

            int[][] endMatrix = new int[num][];

            for (int i = 0; i < matrix.Length; i++)
            {
                int[] z = new int[matrix[i].Length + revMatrix[i].Length];
                matrix[i].CopyTo(z, 0);
                revMatrix[i].CopyTo(z, matrix[i].Length);
                endMatrix[i] = z;
                if (maxLength < matrix[i].Length + revMatrix[i].Length)
                {
                    maxLength = matrix[i].Length + revMatrix[i].Length;
                }

            }

            bool fit = true;

            for (int i = 0; i < endMatrix.Length; i++)
            {
                if (maxLength != endMatrix[i].Length)
                {
                    fit = false;
                    break;
                    
                }
                  
            }

            if (fit)
            {
                foreach (var row in endMatrix)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                    
                }
            }
            else
            {
                var counter = 0;

                foreach (var row in endMatrix)
                {
                    counter += row.Length;
                }

                Console.WriteLine($"The total number of cells is: {counter}");
            }
            
        }
    }
}
