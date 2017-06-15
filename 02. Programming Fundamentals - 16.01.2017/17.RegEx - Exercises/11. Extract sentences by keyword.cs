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
        var word = Console.ReadLine().ToLower();
        var input = Console.ReadLine().Split('!', '.', '?');
        var pattern = @"\b([word]+)\b";
        var replaced = pattern.Replace("word", word);
        var reg = new Regex(replaced);
        for (int i = 0; i < input.Length; i++)
        {
            var matches = reg.Matches(input[i]);
            foreach (Match match in matches)
            {
                if (match.Success == true)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }

    }
}