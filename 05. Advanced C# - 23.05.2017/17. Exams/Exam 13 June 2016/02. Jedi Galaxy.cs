using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new[] {'\n', '\t', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[][] matrix = new int[dimensions[0]][];
            int counter = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[dimensions[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    
                    matrix[row][col] = counter;
                    counter++;
                }
            }

            long gatheredForce = 0;            
            string commands = Console.ReadLine();
           
            while (commands != "Let the Force be with you")
            {
                
                long[] ivoStartPoint = commands.Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();

                commands = Console.ReadLine();

               long[] eFStartPoint = commands.Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();
               
                long ivoRowStartPoint = ivoStartPoint[0];
                long ivoColStartPoint = ivoStartPoint[1];
                long eFRowStartPoint = eFStartPoint[0];
                long eFColStartPoint = eFStartPoint[1];

                while (eFRowStartPoint >= 0 && eFColStartPoint >= 0)
                    {
                        if (eFRowStartPoint < dimensions[0] && eFColStartPoint < dimensions[1])
                        {
                            matrix[eFRowStartPoint][eFColStartPoint] = 0;
                        }
                        eFRowStartPoint--;
                        eFColStartPoint--;

                    }                   
                               
                    while (ivoRowStartPoint >= 0 && ivoColStartPoint < dimensions[1])
                    {
                        if (ivoRowStartPoint < dimensions[0] && ivoColStartPoint >= 0)
                        {
                           gatheredForce += matrix[ivoRowStartPoint][ivoColStartPoint];
                        }
                        ivoRowStartPoint--;
                        ivoColStartPoint++;

                    }
                
                commands = Console.ReadLine();
            }

            Console.WriteLine(gatheredForce);
        }
    }
}
