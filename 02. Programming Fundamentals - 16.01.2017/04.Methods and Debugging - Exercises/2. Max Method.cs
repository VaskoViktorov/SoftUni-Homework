using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication205
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(num1,num2,num3));
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int maxFrom1And2 = Math.Max(num1, num2);
            int max = Math.Max(maxFrom1And2, num3);
            return max;
        }
    }
}
