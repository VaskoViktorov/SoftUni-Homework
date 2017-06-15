using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication389
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex reg = new Regex(@"\d+");
            MatchCollection matches = reg.Matches(text);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
           
        }
    }
}
