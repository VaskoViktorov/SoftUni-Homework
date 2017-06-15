using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication274
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
