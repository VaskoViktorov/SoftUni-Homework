using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string type = Console.ReadLine();

            Predicate<long> evenOrOdd = p =>{ return Math.Abs(p) % 2 == 1; };

            Action<string, string> EvenOrOddLine = (x,y) =>
            {
                long[] nums= x.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                List<long> list = new List<long>();

                for (long i = nums[0]; i <= nums[1]; i++)
                {
                    if (y == "odd" && evenOrOdd(i))
                    {                       
                        list.Add(i);
                    }
                    else if(y == "even" & !evenOrOdd(i))
                    {
                        list.Add(i);
                    }
                }    
                
                Console.WriteLine(string.Join(" ", list));                         
            };

            EvenOrOddLine(input, type);
        }
    }
}
