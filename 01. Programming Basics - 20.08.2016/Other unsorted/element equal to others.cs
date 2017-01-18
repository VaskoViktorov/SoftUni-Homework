using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var result = 0;
            var MaxValue = int.MinValue;

            for (int i = 0; i < sum; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                result += numbers;
                if (MaxValue < numbers)
                    MaxValue = numbers;

            }
            if (MaxValue == result - MaxValue)
                Console.WriteLine("Yes Sum = {0}", MaxValue);
            else
                Console.WriteLine("No Diff = {0}", Math.Abs((result - MaxValue) - MaxValue));
        }
    }
}
