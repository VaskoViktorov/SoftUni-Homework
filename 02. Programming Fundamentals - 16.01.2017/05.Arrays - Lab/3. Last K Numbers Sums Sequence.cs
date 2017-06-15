using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication223
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] arry = new long[n];
            arry[0] = 1;

            for (long i = 1; i < n; i++)
            {
                long result = 0;
                for (long prevI = i - 1; prevI >= 0 && prevI >= i - k; prevI--)
                {
                    result = result + arry[prevI];
                }
                arry[i] = result;
            }
            Console.WriteLine(String.Join(" ", arry));
        }
    }
}
