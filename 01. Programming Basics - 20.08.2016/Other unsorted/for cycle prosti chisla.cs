using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var isPrime = true;
            if (n <2)
            {
                isPrime = false;
            }
            for (int divisor = 2; divisor <= Math.Sqrt(n); divisor++)
            {
                if (n % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
                
            }
            if (isPrime)
            Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
        }
    }
}
