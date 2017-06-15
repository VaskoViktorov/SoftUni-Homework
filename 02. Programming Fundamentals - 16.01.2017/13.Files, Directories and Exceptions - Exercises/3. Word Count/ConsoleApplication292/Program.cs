using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication292
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split().ToArray();
            string[] file = File.ReadAllText("input.txt").ToLower().Split(new string[] {" ","-",",","!","\n","\r","?","." }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var item in words)
            {
                wordsCount[item] = 0;
            }
            
            foreach (var item in file)
            {
                if (wordsCount.ContainsKey(item))
                {
                    wordsCount[item] += 1;
                }
            }
            wordsCount = wordsCount.OrderByDescending(w => w.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in wordsCount)
            {
                File.AppendAllText("output.txt", $"{item.Key} - {item.Value}\r\n");
            }
                
            
                
            
        }
    }
}
