using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication158
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            try
            {
                long num = long.Parse(numbers);

                Console.WriteLine("{0} can fit in:", num);
                if (num >= -128 && num <= 127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (num >= 0 && num <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (num >= -32728 && num <= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (num >= 0 && num <= 65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (num >= -2147483648 && num <= 2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (num >= 0 && num <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (num >= -9223372036854775808 && num <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }


            }
            catch
            {

                Console.WriteLine($"{numbers} can't fit in any type");
            }
        }
    }
}
