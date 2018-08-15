namespace _2.Recursive_Factorial
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            return n*Factorial(n - 1);
        }
    }
}