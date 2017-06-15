using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication271
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < text.Length - 1; pos1++)
            {
                int pos2 = rnd.Next(text.Length);
                var temp = text[pos1];
                text[pos1] = text[pos2];
                text[pos2] = temp;
            }

            Console.WriteLine(string.Join("\r\n", text));



        }
    }
}
