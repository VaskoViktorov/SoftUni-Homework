using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication80
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var blanks = n-2;
           
            Console.WriteLine("{0}*",new string(' ',blanks+1));
            for (int row = 1; row < n; row++)
            {
                Console.Write("{0}*",new string (' ',blanks));
                for (int x = 0; x < row; x++)
                {
                    Console.Write("-*");
                    
                }
                Console.WriteLine();
                blanks--;
            }
                blanks = 1;
            for (int j = n-2; j >= 0 ; j--)
            {
                Console.Write("{0}*", new string(' ', blanks));
                for (int x = 0; x < j; x++)
                {
                    Console.Write("-*");

                }
                Console.WriteLine();
                blanks++;
            }
           
        }
    }
}
