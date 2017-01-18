using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)

        {
            
            

            var n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == 1 || row == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (col == 1 || col == n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
