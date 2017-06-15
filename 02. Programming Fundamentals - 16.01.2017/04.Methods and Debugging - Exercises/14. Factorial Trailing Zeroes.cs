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
            //input
            int num = int.Parse(Console.ReadLine());

            //Invoke Zero Counter
            var counter = GetZero(GetFactorial(num));

            //Print
            Console.WriteLine(counter);

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

        static BigInteger GetZero(BigInteger num)
        {
            var lenght = num.ToString();
            BigInteger counter = 0;
           string zero = "0";
            for (int i = 1; i <= lenght.Length; i++)
            {
                zero = lenght.Substring(lenght.Length-i, 1);
                if (zero == "0")
                {
                    counter++;
                }
                else
                {
                    break;
                }

            }
            return counter;
        }


    }
}
