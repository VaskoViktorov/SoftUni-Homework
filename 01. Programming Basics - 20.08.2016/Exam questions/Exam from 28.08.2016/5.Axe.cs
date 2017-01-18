using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication136
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftoutdots = n*3;
            var middledots = 1;
            var rightdots = n*2-3;
            Console.WriteLine("{0}**{1}",new string('-',leftoutdots ), new string('-',n*2-2 ));
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftoutdots), new string('-', middledots), new string('-', rightdots));
                middledots += 1;
                rightdots -= 1;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftoutdots), new string('-', middledots-1), new string('-', rightdots+1));
            }
            middledots -= 1;
            rightdots += 1;
            for (int i = 0; i < n/2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftoutdots), new string('-', middledots), new string('-', rightdots));
                leftoutdots -= 1;
                middledots +=2;
                rightdots -= 1;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftoutdots), new string('*', middledots), new string('-', rightdots));
        }
    }
}
