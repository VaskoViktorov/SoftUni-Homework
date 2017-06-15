using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication400
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[a-zA-Z]{1}[a-zA-Z0-9_]{2,24}\b";            
            Regex reg = new Regex(pattern);

            MatchCollection matches = reg.Matches(text);
            Queue<string> queue = new Queue<string>();
            foreach (Match match in matches)
            {
               queue.Enqueue(match.ToString());
            }
            var firstWord = string.Empty;
            var secondWord = string.Empty;
            var max = 0;
            while (queue.Count != 1)
            {
               var a = queue.Dequeue();
                var b = queue.Peek();
               
                if (a.Length + b.Length > max)
                {
                    max = a.Length + b.Length;
                    firstWord = a;
                    secondWord = b;
                }
            }
            Console.WriteLine($"{firstWord}\n{secondWord}");


        }
    }
}


