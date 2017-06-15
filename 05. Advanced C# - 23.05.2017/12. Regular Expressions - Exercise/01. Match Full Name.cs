using System;
using System.Text.RegularExpressions;


namespace ConsoleApplication401
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");
            MatchCollection matches = reg.Matches(input);

            while (input != "end")
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                    
                }
                input = Console.ReadLine();
                matches = reg.Matches(input);
            }         
        }
    }
}
