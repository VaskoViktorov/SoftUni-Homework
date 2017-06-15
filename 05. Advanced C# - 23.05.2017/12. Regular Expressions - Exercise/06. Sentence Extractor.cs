using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractSentencesByKeyword
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine(); 
        string pattern = @"[\w\s]*\s(word)\s[\w\s]*[!?.]";
        string replaced = pattern.Replace("word", word);
        Regex reg = new Regex(replaced);
       
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                
                    Console.WriteLine(match);
                
            }
        

    }
}