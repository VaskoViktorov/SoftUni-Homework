using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication353
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =    Console.ReadLine();
            string pattern = @"([^\d]+)(\d+)";
            Regex reg = new Regex(pattern);
            MatchCollection rage = reg.Matches(input);
            StringBuilder msg = new StringBuilder();

            foreach (Match match in rage)
            {
                string a = match.Groups[1].ToString();
                long b = long.Parse(match.Groups[2].ToString());

                for (int i = 0; i < b; i++)
                {
                    msg.Append(a);
                }                
            }
            Console.WriteLine($"Unique symbols used: {msg.ToString().ToUpper().Distinct().Count()}");
            Console.WriteLine(msg.ToString().ToUpper());
        }
    }
}
