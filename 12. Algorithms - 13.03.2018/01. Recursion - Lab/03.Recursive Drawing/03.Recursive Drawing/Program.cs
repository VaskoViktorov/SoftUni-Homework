namespace _03.Recursive_Drawing
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }

        static void PrintFigure(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));

            PrintFigure(n - 1);

            Console.WriteLine(new string('#', n));
        }
    }
}