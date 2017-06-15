using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //The files are in the solution folder

            using (StreamReader wordReader = new StreamReader(@"..\..\..\words.txt"))
            {
                Dictionary<string,int> result = new Dictionary<string, int>();
                string line = wordReader.ReadLine();
                Queue<string> words = new Queue<string>();

                while (line != null)
                {                                                   
                    words.Enqueue(line.ToLower());
                    line = wordReader.ReadLine();
                }
                
                using (StreamReader textReader = new StreamReader(@"..\..\..\text.txt"))
                {
                    line = textReader.ReadLine();
                    Regex reg = new Regex(@"W*([\w']+)W*");

                    while (line != null)
                    {
                        var arr = reg.Matches(line).Cast<Match>().Select(m => m.Value).ToArray();

                        for (int i = 0; i < arr.Length; i++)
                        {

                            for (int j = 0; j <=words.Count; j++)
                            {
                                var word = words.Dequeue();

                                if (word == arr[i].ToLower())
                                {
                                    if (!result.ContainsKey(word))
                                    {
                                        result[word] = 0;
                                    }
                                    result[word]++;
                                }

                                words.Enqueue(word);
                            }
                           
                        }

                        line = textReader.ReadLine();
                    }

                    using (StreamWriter writer = new StreamWriter(@"..\..\..\result.txt"))
                    {
                        foreach (var item in result.OrderByDescending(x => x.Value))
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                                              
                    }
                }
            }
        }
    }
}
