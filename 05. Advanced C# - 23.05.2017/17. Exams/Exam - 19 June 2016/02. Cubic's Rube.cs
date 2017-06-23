using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
           long num = long.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            long[,,]matrix = new long[num,num,num];

            while (input != "Analyze")
            {
                
                long[] cords = input.Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();               
               
                if (cords[0] <= num && cords[0] >= 0 && cords[1] <= num && cords[1] >= 0 && cords[2] <= num && cords[2] >= 0)
                {
                    if (matrix[cords[0], cords[1], cords[2]] == 0)
                    {
                        matrix[cords[0], cords[1], cords[2]] = cords[3];
                    }
                    

                }
                
                input = Console.ReadLine();
            }
            var counter = 0;
            long sum = 0;
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    for (int hig = 0; hig < num; hig++)
                    {
                        if (matrix[row,col,hig] == 0)
                        {
                            counter++;
                        }
                        else
                        {
                            sum += matrix[row, col, hig];
                        }
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(counter);
        }
    }
}
