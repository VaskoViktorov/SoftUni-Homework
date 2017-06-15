using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {         
            List<long> input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            Predicate<long> pred = n => { return Math.Abs(n) % 2 == 1; };

            Func<List<long>, List<long>> func = x =>
            {
                List<long> odd = new List<long>();
                List<long> even = new List<long>();
                odd = x.Where(n => pred(n)).OrderBy( n => n).ToList();
                even = x.Where(n => !pred(n)).OrderBy(n => n).ToList();
                even.AddRange(odd);

                return even;
            };

            Console.WriteLine(string.Join(" ", func(input)));
        }
    }
}
