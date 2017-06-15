using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            long length = long.Parse(Console.ReadLine());
            List<string> input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Predicate<string> pred = n => { return n.Length <= length;};

            Func<List<string>,long, List<string>> func = (x,y) =>
            {
                x = x.Where(n => pred(n)).ToList();

                return x;
            };

            input = func(input,length);

            foreach (var name in input)
            {
                Console.WriteLine(name);
            }



        }
    }
}
