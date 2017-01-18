using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication98
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var monkey = 1;
            var tire = n/2-1;
            Console.WriteLine(new string('*',n));
            
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("*{0}{1}{0}*",new string ('-',tire),new string('@', monkey));
                tire--;
                monkey+=2;
            }
            tire = 1;
            if (n < 5)
            {
                monkey = n / 2 - 1;
            }
            else
                monkey -= 4;
            for (int g = 1; g <= n/2-1; g++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('-', tire), new string('@', monkey));
                tire++;
                monkey -= 2;
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
