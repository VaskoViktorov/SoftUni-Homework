using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication383
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string,int[]>> Dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            string pattern = @"([A-Z]\w+)\s([A-Z]\w+)\s(.+)";
            Regex reg = new Regex(pattern);

            for (int i = 0; i < amount; i++)
            {
                string input = Console.ReadLine();
                if (reg.IsMatch(input))
                {
                    Match match = reg.Match(input);
                    string type = match.Groups[1].ToString();
                    string name = match.Groups[2].ToString();
                    string[] stats = match.Groups[3].ToString().Split();

                    if (stats[0] == "null")
                    {
                        stats[0] = "45";
                    }
                    if (stats[1] == "null")
                    {
                        stats[1] = "250";
                    }
                    if (stats[2] == "null")
                    {
                        stats[2] = "10";
                    }

                    int[] newStats = new int[3]
                    {
                        int.Parse(stats[0]),
                        int.Parse(stats[1]),
                        int.Parse(stats[2])
                    };
                    
                    if (!Dragons.ContainsKey(type))
                    {
                        Dragons.Add(type, new SortedDictionary<string, int[]>());
                    }
                    if (!Dragons[type].ContainsKey(name))
                    {
                        Dragons[type].Add(name, newStats);
                    }
                    else
                    {
                        Dragons[type][name] = newStats;
                    }
                }
            }
            decimal dmg = 0;
            decimal hp = 0;
            decimal ar = 0;
            int counter = 0;
            Queue<string> drag = new Queue<string>();
            foreach (var type in Dragons)
            {
                Console.Write($"{type.Key}::");
                foreach (var dragon in type.Value)
                {
                    dmg += dragon.Value[0];
                    hp += dragon.Value[1];
                    ar += dragon.Value[2];
                    counter++;
                    drag.Enqueue($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
                Console.WriteLine("({0:f2}/{1:f2}/{2:f2})", dmg/counter, hp/counter, ar/counter);
                foreach (var one in drag)
                {
                    Console.WriteLine(one);
                }
                dmg = 0;
                hp = 0;
                ar = 0;
                counter = 0;
                drag.Clear();
            }
        }
    }
}
