using System;
using System.Linq;

namespace _05.Generating_Combinations
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int n = int.Parse(Console.ReadLine());

            GenCombos(array, new int[n], 0, 0);
        }

        static void GenCombos(int[] set, int[] vector, int index, int border)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
                return;
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenCombos(set, vector, index + 1, i + 1);
                }
            }           
        }
    }
}

