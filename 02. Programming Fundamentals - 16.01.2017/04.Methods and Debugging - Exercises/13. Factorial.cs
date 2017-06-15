using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication216
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(num));
            
        }
        static BigInteger GetFactorial(BigInteger num)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }


    }
}
