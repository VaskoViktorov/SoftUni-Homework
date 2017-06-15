using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication294
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> input = new Stack<char>(Console.ReadLine().ToCharArray());
            StringBuilder output = new StringBuilder();

            while (input.Count != 0)
            {
                output.Append(input.Pop());
            }
            Console.WriteLine(output.ToString());
        }
    }
}
