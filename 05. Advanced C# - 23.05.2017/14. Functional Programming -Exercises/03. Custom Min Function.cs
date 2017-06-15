using System;
using System.Linq;

namespace ConsoleApp5
{
   public class Program
    {
       public static void Main()
        {
            string input = Console.ReadLine();

            Func<string, decimal> funcMin = x =>
            {
              decimal min =  x.Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                              .Select(decimal.Parse)
                              .Min();

                return min;
            };

            Console.WriteLine(funcMin(input));
        }
    }
}
