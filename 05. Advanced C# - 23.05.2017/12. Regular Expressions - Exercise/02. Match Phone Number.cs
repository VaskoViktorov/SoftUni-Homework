using System;
using System.Text.RegularExpressions;


namespace ConsoleApplication401
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"\+359\s2\s[0-9]{3}\s[0-9]{4}|\+359-2-[0-9]{3}-[0-9]{4}\b");
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
