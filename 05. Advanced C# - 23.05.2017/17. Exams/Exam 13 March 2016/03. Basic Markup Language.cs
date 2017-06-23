using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var counter = 0;

            Regex reg = new Regex(@"<\s*(\w+)\s(.+)");
            Regex firstTwoCommands = new Regex(@"\w+\s*=\s*""(.+?)""");
            Regex thirdCommand = new Regex(@"\w+\s*=\s*""(.+?)""\s*\w+\s*=\s*""(.+?)""");

            while (command != "<stop/>")
            {
                StringBuilder word = new StringBuilder();
                Match match = reg.Match(command);

                switch (match.Groups[1].ToString())
                {
                    case "inverse":
                        
                        Match secondMatch = firstTwoCommands.Match(match.Groups[2].ToString());
                        foreach (var letter in secondMatch.Groups[1].ToString())
                        {
                            var current = string.Empty;
                            if (letter >= 65 && letter <= 90)
                            {
                                current = letter.ToString().ToLower();
                            }
                            else
                            {
                                current = letter.ToString().ToUpper();
                            }
                            word.Append(current);
                        }
                        if (word.Length != 0)
                        {
                            counter++;
                            Console.WriteLine($"{counter}. {word}");
                        }                      
                        break;

                    case "reverse":
                        
                        Match thirdMatch = firstTwoCommands.Match(match.Groups[2].ToString());
                        var currentWord = thirdMatch.Groups[1].ToString();

                        for (int i = currentWord.Length-1; i >= 0 ; i--)
                        {
                            word.Append(currentWord[i]);
                        }
                        if (word.Length != 0)
                        {
                            counter++;
                            Console.WriteLine($"{counter}. {word}");
                        }                      
                        break;

                    case "repeat":
                        Match fourthMatch = thirdCommand.Match(match.Groups[2].ToString());
                        var times = int.Parse(fourthMatch.Groups[1].ToString());
                        var currWord = fourthMatch.Groups[2].ToString();
                        for (int i = 0; i < times; i++)
                        {
                            counter++;
                            Console.WriteLine($"{counter}. {currWord}");
                        }
                        break;
                } 
                
                command = Console.ReadLine();
            }
        }
    }
}
