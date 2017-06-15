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
            Regex reg = new Regex(Console.ReadLine());
            MatchCollection match = reg.Matches(Console.ReadLine());

            Console.WriteLine(match.Count);
        }
    }
}
