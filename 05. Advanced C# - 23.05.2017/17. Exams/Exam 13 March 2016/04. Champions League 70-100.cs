using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] substrings = Regex.Split(input, @"\s*\|\s*");
            Dictionary<string, Results> teams = new Dictionary<string, Results>();
            List<Results> results = new List<Results>();

            while (input != "stop")
            {
                var win = 0;
                if (!teams.ContainsKey(substrings[0]))
                {
                    var res = new Results();
                    res.Oponents = new SortedSet<string>();
                    res.Wins = 0;
                    teams.Add(substrings[0], res);
                }
                var matchResult1 = substrings[2].Split(new[] { ' ', ':', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                var matchResult2 = substrings[3].Split(new[] { ' ', ':', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                var teamGoals = matchResult1[0] + matchResult2[1];
                var oponentGoals = matchResult1[1] + matchResult2[0];
                if (teamGoals >= oponentGoals)
                {
                    win = 1;
                }
                teams[substrings[0]].Oponents.Add(substrings[1]);
                teams[substrings[0]].Wins += win;

                win = 0;
                if (!teams.ContainsKey(substrings[1]))
                {
                    var res = new Results();
                    res.Oponents = new SortedSet<string>();
                    res.Wins = 0;
                    teams.Add(substrings[1], res);
                }
                if (teamGoals < oponentGoals)
                {
                    win = 1;
                }
                teams[substrings[1]].Oponents.Add(substrings[0]);
                teams[substrings[1]].Wins += win;

                input = Console.ReadLine();
                substrings = Regex.Split(input, @"\s*\|\s*");
            }

            foreach (var one in teams.OrderByDescending(x => x.Value.Wins).ThenBy(y => y.Key))
            {
                Console.WriteLine(one.Key);
                Console.WriteLine($"- Wins: {one.Value.Wins}");
                Console.WriteLine($"- Opponents: {string.Join(", ", one.Value.Oponents.OrderBy(x => x))}");

            }
        }

    }

    public class Results
    {
        public int Wins { get; set; }
        public SortedSet<string> Oponents { get; set; }
    }
}
