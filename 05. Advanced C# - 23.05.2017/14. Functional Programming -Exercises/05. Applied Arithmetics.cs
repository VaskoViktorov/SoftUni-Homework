using System;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            long[] input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            string command = Console.ReadLine();

            Func<long[], long[]> add = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] += 1;
                }

                return x;
            };

            Func<long[], long[]> multiply = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] *= 2;
                }

                return x;
            };

            Func<long[], long[]> subtract = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] -= 1;
                }

                return x;
            };

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        input = add(input);
                        break;
                    case "multiply":
                        input = multiply(input);
                        break;
                    case "subtract":
                        input = subtract(input);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", input));
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
