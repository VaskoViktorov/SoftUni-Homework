using System;

namespace _04.Generating_01_Vectors
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Gen01(new int[n], 0);
        }

        static void Gen01(int[] vector, int index)
        {
            for (int i = 0; i <= 1; i++)
            {
                if (index > vector.Length - 1)
                {
                    Console.WriteLine(string.Join("", vector));
                    return;
                }

                vector[index] = i;           
                Gen01(vector, index + 1);               
            }
        }
    }
}

