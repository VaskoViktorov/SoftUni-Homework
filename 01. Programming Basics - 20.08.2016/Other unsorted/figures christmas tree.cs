using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var blancks = n - 1;
            int stars = 1;
            Console.Write(new string(' ', n+1));
            Console.WriteLine("|");
            for (int i = 0; i < n; i++)
            {

                Console.Write(new string(' ', blancks));
                Console.Write(new string('*', stars));
                blancks--;
                Console.Write(" | ");
                Console.WriteLine(new string('*', stars));

                stars++;
            }
        }
    }
}
