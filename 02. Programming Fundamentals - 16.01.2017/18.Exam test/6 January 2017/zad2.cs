using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication347
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> awardList = new Dictionary<string, List<string>>();

            while (input[0] != "dawn")
            {
                if (participants.Contains(input[0]) && songs.Contains(input[1]))
                {
                    if (!awardList.ContainsKey(input[0]))
                    {
                        awardList.Add(input[0], new List<string> { input[2] });
                    }
                    else
                    {
                        if (!awardList[input[0]].Contains(input[2]))
                        {
                            awardList[input[0]].Add(input[2]);
                        }
                    }
                }
                input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (awardList.Count != 0)
            {
                foreach (var name in awardList.OrderByDescending(x => x.Value.Count()).ThenBy(h => h.Key))
                {
                    Console.WriteLine($"{name.Key}: {name.Value.Count} awards");
                    name.Value.Sort();
                    foreach (var award in name.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
