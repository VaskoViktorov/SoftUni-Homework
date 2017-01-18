using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication156
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());

            float diff = Math.Abs(Math.Abs(num1) - Math.Abs(num2));

            if (diff >= 0.0000009)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}

