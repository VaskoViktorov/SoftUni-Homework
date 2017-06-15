using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication199
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(RiseToPower(num,pow));
        }
        static double RiseToPower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
