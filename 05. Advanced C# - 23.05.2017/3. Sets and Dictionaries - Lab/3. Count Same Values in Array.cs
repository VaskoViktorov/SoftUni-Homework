using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication370
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Console.ReadLine()
                             .Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            
            SortedDictionary<decimal, int> counter = new SortedDictionary<decimal, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!counter.ContainsKey(input[i]))
                {
                    counter[input[i]] = 0;
                }
                counter[input[i]]++;
            }
            
            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
             

        }
    }
}
