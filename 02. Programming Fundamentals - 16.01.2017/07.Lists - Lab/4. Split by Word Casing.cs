using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication251
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
            StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> LowerCaseWords = new List<string>();
            List<string> UpperCaseWords = new List<string>();
            List<string> MixedCaseWords = new List<string>();

            string holder = "";
            char n = ' ';
            int upperCounter = 0;
            int lowerCounter = 0;

            for (int i = 0; i < list.Count; i++)
            {
                holder = list[i];

                for (int j = 0; j < list[i].Length; j++)
                {
                    n = holder[j];

                    if (n >= 65 && n <= 90)
                    {
                        upperCounter++;                       
                    }
                    else if (n >= 97 && n <= 122)
                    {
                        lowerCounter++;
                    }
                }

                if (lowerCounter == list[i].Length)
                {
                    LowerCaseWords.Add(list[i]);
                }
                else if (upperCounter == list[i].Length)
                {
                    UpperCaseWords.Add(list[i]);
                }
                else
                {
                    if (list[i] != "")
                    {
                        MixedCaseWords.Add(list[i]);
                    }                   
                }

                upperCounter = 0;
                lowerCounter = 0;
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", LowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", MixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", UpperCaseWords));

        }
    }
}


