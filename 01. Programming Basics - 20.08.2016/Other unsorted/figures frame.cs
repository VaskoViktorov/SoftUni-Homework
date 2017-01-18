using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("+");
                for (int n = 1; n <= num-2; n++)
                {
                    Console.Write(" -");
                    
                }
                Console.WriteLine(" +");
                break;

            }
            
            for (int i = 1; i <= num-2; i++)
            {
                Console.Write("|");
                for (int n = 1; n <= num-2; n++)
                {
                    Console.Write(" -");

                }
                Console.WriteLine(" |");
                ;

            }
            for (int i = 1; i <= num; i++)
            {
                Console.Write("+");
                for (int n = 1; n <= num-2; n++)
                {
                    Console.Write(" -");

                }
                Console.WriteLine(" +");
                break;

            }
        }
    }
}
