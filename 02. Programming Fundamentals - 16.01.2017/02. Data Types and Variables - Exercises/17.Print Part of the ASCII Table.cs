using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication157
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            char symbol = ' ';

            for (int i = start; i <= finish; i++)
            {

                symbol = Convert.ToChar(i);
                Console.Write($"{symbol} ");
            }
        }
    }
}
