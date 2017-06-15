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

            Regex reg = new Regex(@"^((([0][0-9])|11|12):(([0][0-9])|[0-5][0-9]):(([0][0-9])|[0-5][0-9])\s(A|P)M)$");
            Match match = reg.Match(text);

            while (text != "END")
            {
                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                text = Console.ReadLine();
                match = reg.Match(text);

            }
        }
    }
}
