using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication117
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}\\ /{0}",new string('*', n-2));
            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
            }
            Console.WriteLine("{0}@{0}", new string(' ', n-1));
           
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
               
            }
            Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
        }
    }
}
