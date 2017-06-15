using System;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            long[] input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long command = long.Parse(Console.ReadLine());

            Predicate<long> divide = x => { return x % command != 0; };

            Func<long[], long[]> reverse = x =>
            {
                x = x.Where(n => divide(n)).Reverse().ToArray();

                return x;
            };

            input = reverse(input);

            Console.WriteLine(string.Join(" ", input));
           


        }
    }
}
