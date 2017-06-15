using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new[] { ' ', ':', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, List<long>> Cities = new Dictionary<string, List<long>>();

            for (int i = 0; i < input.Count - 1; i += 2)
            {
                if (!Cities.ContainsKey(input[i]))
                {
                    Cities.Add(input[i], new List<long>());
                }
                Cities[input[i]].Add(long.Parse(input[i + 1]));
            }

            long limit = long.Parse(Console.ReadLine());

            if (limit != 0 || input.Count != 0)
            {
                foreach (var city in Cities.OrderByDescending(x => x.Value.Sum()))
                {
                    if (city.Value.Sum() > limit)
                    {
                        Console.WriteLine($"{city.Key}: {string.Join(" ", city.Value.OrderByDescending(x => x).Take(5))}");

                    }
                }
            }
        }
    }
}
