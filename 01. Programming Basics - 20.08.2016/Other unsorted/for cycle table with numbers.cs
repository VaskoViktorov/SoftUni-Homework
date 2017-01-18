using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication67
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var num = row + col + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write("{0} ",num);
                }
                Console.WriteLine();
            }
        }
    }
}
