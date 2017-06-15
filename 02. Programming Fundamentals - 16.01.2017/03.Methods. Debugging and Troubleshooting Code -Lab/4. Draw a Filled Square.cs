using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication197
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            OuterLine(number);
            for (int i = 1; i <= number-2; i++)
            {
                InnerLine(number);
                
            }
            OuterLine(number);

        }
        static void OuterLine(int n)
        {
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void InnerLine(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {

                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
