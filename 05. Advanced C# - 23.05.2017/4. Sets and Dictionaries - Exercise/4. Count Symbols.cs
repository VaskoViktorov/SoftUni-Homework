using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication372
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           SortedDictionary<char, int> uniqueChars = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!uniqueChars.ContainsKey(input[i]))
                {
                    uniqueChars[input[i]] = 0;
                }
                uniqueChars[input[i]]++;
            }
            
            foreach (var kvp in uniqueChars)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
