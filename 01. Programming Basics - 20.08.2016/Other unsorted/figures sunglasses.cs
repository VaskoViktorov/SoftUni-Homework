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
            

           
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.WriteLine(new string('*', n * 2));
                }
                else if (i == (n - 1) / 2)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('|', n));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.WriteLine(new string('*', 1));
                }
                else
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.WriteLine(new string('*', 1));
                }
            }
          
        }
    }
}
