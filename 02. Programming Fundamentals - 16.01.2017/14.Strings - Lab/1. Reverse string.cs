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
            string text = Console.ReadLine();
            StringBuilder reversedText = new StringBuilder();
            for (int i = text.Length; i >0 ; i--)
            {
                reversedText.Append(text.Substring(i-1, 1));
            }
            Console.WriteLine(reversedText);
        }
    }
}
