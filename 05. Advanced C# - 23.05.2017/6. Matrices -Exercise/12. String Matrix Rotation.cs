using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\w+\((\d+)\)");
            Match match = reg.Match(Console.ReadLine());
            long deg = (long.Parse(match.Groups[1].ToString()) / 90)% 4;            
            string word = Console.ReadLine();
            long maxLength = 0;
            List<string> words = new List<string>();

            while (word != "END")
            {
                words.Add(word);               
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                }
                word = Console.ReadLine();
            }

            string holder = String.Empty;
            List<string> output = new List<string>();

            if (deg == 0 || deg == 2)
            {
                
                    for (int i = 0; i < words.Count; i++)
                    {
                        for (int j = 0; j < maxLength; j++)
                        {
                        if (words[i].Length <= j)
                        {
                            holder +=" ";
                        }
                        else
                        {
                            holder += words[i][j];
                        }                          
                    }
                        output.Add(holder);
                        holder = string.Empty;
                    }
                if (deg == 2)
                {
                    output.Reverse();
                    for (int i = 0; i < output.Count; i++)
                    {
                        char[] charArray = output[i].ToCharArray();
                        Array.Reverse(charArray);
                        output[i] = string.Join("", charArray);
                    }
                }              
                
            }
            else if (deg == 1 || deg == 3)
            {
                words.Reverse();
                for (int j = 0; j < maxLength; j++)
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        if (words[i].Length <= j)
                        {
                            holder += " ";
                        }
                        else
                        {
                            holder += words[i][j];
                        }
                            
                    }
                    output.Add(holder);
                    holder = string.Empty;
                }
                if (deg == 3)
                {
                    output.Reverse();
                    for (int i = 0; i < output.Count; i++)
                    {
                        char[] charArray = output[i].ToCharArray();
                        Array.Reverse(charArray);
                        output[i] = string.Join("", charArray);
                    }
                }

            }
          
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
