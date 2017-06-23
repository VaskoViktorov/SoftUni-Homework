using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder text =new StringBuilder();

            while (num >0)
            {

                text.Append(Console.ReadLine());
                num--;
            }
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            Regex reg = new Regex(@"static\s+[a-zA-Z]+\s+([a-zA-Z0-9]+)");
            MatchCollection methodMatch = reg.Matches(text.ToString());
            Queue<string> asd = new Queue<string>();
            foreach (Match one in methodMatch)
            {
                result.Add(one.Groups[1].ToString(), new List<string>());
                asd.Enqueue(one.Groups[1].ToString());
            }
            string[] cutedTexxt = Regex.Split(text.ToString(), @"static\s+[a-zA-Z]+\s+([a-zA-Z0-9]+)");
            Regex regg = new Regex(@"([A-Z][A-Za-z]+)\(|([a-z]+[A-Z][a-z]+)\(");

            for (int i = 0; i <= result.Count-1; i++)
            {
                var a = i*2+2;
                MatchCollection match = regg.Matches(cutedTexxt[a]);
                var b = asd.Dequeue();
                foreach (Match one in match)
                {
                    string ab = one.Groups[0].ToString();
                    
                    result[b].Add(ab.Substring(0,ab.Length-1));
                }

            }

            foreach (var kvp in result.OrderByDescending(x=> x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count == 0)
                {
                    Console.WriteLine(
                        $"{kvp.Key} -> None");
                }
                else
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Count} -> {string.Join(", ", kvp.Value.OrderBy(x => x))}");
                }
                
            }
        }
    }
}
