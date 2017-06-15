using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication209
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(number));
        }
        static bool isPrime(long number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (long i = 2; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

    }
}

