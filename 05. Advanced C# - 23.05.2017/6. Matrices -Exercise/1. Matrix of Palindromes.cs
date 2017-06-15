using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[][] matrix = new string[input[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new string[input[1]];
                
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = alphabet[row].ToString() + alphabet[row + col].ToString() + alphabet[row].ToString();
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
