using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication262
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var item in words)
            {
                var holder = item;
                if (dict.ContainsKey(holder))
                {
                    dict[holder]++;
                }
                else
                {
                    dict[holder] = 1;
                }
            }
            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(string.Join(" ",$"{pair.Key} "));
                }
            }

        }
    }
}
