using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            while (num > 0)
            {
                string line = Console.ReadLine();
                text.Append(line);
                num--;               
            }

            string patternOne = Console.ReadLine();
            string patternTwo = Console.ReadLine();

            Queue<int> indexes = new Queue<int>(Console.ReadLine().Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Regex name = new Regex(patternOne + @"([A-Za-z]{" + patternOne.Length + @"})(?![a-zA-Z])");
            Regex msg = new Regex(patternTwo + @"([A-Za-z0-9]{" + patternTwo.Length + @"})(?![a - zA - Z])");

            List <string> names = new List<string>();
            List<string> msgs = new List<string>();

           
                MatchCollection matchName = name.Matches(text.ToString());

                foreach (Match one in matchName)
                {
                    names.Add(one.Groups[1].ToString());
                }

                MatchCollection matchMsg = msg.Matches(text.ToString());

                foreach (Match one in matchMsg)
                {
                    msgs.Add(one.Groups[1].ToString());
                }
            

            List<string> wholeMsg = new List<string>();

            foreach (var one in names)
            {
                
                while (indexes.Count != 0)
                {
                    var a = indexes.Dequeue();
                    if (msgs.Count >= a && a > 0)
                    {
                        wholeMsg.Add(one + " - " + msgs[a - 1]);
                        break;
                    }
                }
            }

            foreach (var compMsg in wholeMsg)
            {
                Console.WriteLine(compMsg);
            }
        }
    }
}
