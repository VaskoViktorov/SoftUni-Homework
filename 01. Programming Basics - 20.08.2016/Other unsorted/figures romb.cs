using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var blanks = num - 1;
            for (int row = 1; row <= num; row++)
            {
                Console.Write(new string(' ', blanks));

                for (int i = 0; i < row; i++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                blanks--;
            }
            blanks = 1;
            for (int row = 1; row <= num-1; row++)
            {
                
                Console.Write(new string(' ', blanks));

                for (int i = row; i <num; i++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                blanks++;
            }
        }
    }
}
