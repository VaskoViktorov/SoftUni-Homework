using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication408
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Action<string> addVat = x =>
            {
                 x.Split(new char[] {'\n', '\t', ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(z =>double.Parse(z)+double.Parse(z)*0.2)                   
                    .ToList()
                    .ForEach(z =>Console.WriteLine("{0:f2}",z));
            };

            addVat(input);
        }
    }
}
