using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder sentence = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                sentence.Append(Console.ReadLine() + " ");
            }

            Console.WriteLine(sentence.ToString());
        }

    }
}
