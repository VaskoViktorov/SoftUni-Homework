using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication145
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine($"Before:\na = {num2}\nb = {num1}\nAfter:\na = {num1}\nb = {num2}");

        }
    }
}
