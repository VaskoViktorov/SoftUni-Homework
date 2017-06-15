using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication307
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:^|\s)([a-zA-Z0-9][\.\-_a-zA-Z0-9]*@[a-zA-z\-]+(\.[a-z]+)+\b)";
            string input =    Console.ReadLine();
            Regex other = new Regex(pattern);
            MatchCollection matches = other.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
            


        }
    }
}
