using System;
using System.Text.RegularExpressions;


namespace ConsoleApplication401
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"(.)\1+");
            Console.WriteLine(reg.Replace(input, "$1"));
        }
    }
}
