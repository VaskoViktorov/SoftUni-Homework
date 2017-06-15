using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication295
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i <= text.Length - word.Length; i++)
            {
                if (word.Equals(text.Substring(i, word.Length)))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
