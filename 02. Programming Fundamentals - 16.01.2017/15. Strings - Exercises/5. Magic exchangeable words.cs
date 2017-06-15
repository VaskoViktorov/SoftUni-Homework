using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication303
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();
            List <char> firstWord = new List<char>();
            List<char> secondWord = new List<char>();
            int min = Math.Min(firstWord.Count, secondWord.Count);
            foreach (char item in text[0])
            {
                firstWord.Add(item);
            }
            foreach (char item in text[1])
            {
                secondWord.Add(item);
            }

            firstWord = firstWord.Distinct().ToList();
            secondWord =  secondWord.Distinct().ToList();
            if (firstWord.Count.Equals(secondWord.Count))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
