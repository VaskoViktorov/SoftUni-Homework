using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication163
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                for (int a = 0; a < numbers; a++)
                {
                    for (int b = 0; b < numbers; b++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + a);
                        char third = (char)('a' + b);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }

            }
        }
    }
}
