using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication306
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = $"<a.*?href.*?=(.*)>(.*?)<\\/a>";
            Regex reg = new Regex(pattern);
                               
            while (input != "end")
            {
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replace);
                Console.WriteLine(replaced);
                 input = Console.ReadLine();
            }
        }
    }
}
