using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication238
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            long[] arry = new long[num - 1];
            long[] primes = new long[num - 1];
            for (int i = 2; i <= num; i++)
            {
                arry[i - 2] = i;
            }

            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] == 2 || arry[i] == 3 || arry[i] == 5 || arry[i] == 7 || arry[i] == 11)
                {
                    primes[i] = arry[i];
                }

                else if (arry[i] % 2 != 0 && arry[i] % 3 != 0 && arry[i] % 5 != 0 && arry[i] % 7 != 0 && arry[i] % 11 != 0)
                {
                    primes[i] = arry[i];
                }
            }


            foreach (var item in primes)
            {
                if (item != 0)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
