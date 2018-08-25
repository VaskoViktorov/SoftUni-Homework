using System;
using System.Linq;

namespace _01.Recursive_Array_Sum
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int[] array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            Console.WriteLine(Sum(array, 0));

        }

        static int Sum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }
            return array[index] + Sum(array, index + 1);
        }
    }
}
