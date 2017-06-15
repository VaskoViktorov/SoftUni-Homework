using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication407
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Action<string> result = x =>
            {
                if (x != string.Empty)
                {
                    string[] output = x.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    foreach (var i in output)
                    {
                        if (char.IsUpper(i[0]))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            };

            result(input);
        }
    }
}