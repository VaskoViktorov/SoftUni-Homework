using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication336
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            string[] teams = new string[2];
            string teamA = "";
            string teamB = "";
            uint teamAGoals = 0;
            uint teamBGoals = 0;
            uint a = 0;
            uint b = 0;
            var aa = 0;
            var bb = 0;
            Dictionary<string, uint> TeamAndPoints = new Dictionary<string, uint>();
            Dictionary<string, uint> TeamAndGoals = new Dictionary<string, uint>();
            while (input != "final")
            {
                teams = input.Split().ToArray();
                aa = teams[0].IndexOf(key);
                bb= teams[0].LastIndexOf(key);
                teamA = string.Join("", teams[0].Skip(aa + key.Length).Take(teams[0].Length - (key.Length + aa) - (teams[0].Length - bb)).Reverse()).ToUpper();
                aa = teams[1].IndexOf(key);
                bb = teams[1].LastIndexOf(key);
                teamB = string.Join("", teams[1].Skip(aa + key.Length).Take(teams[1].Length - (key.Length + aa) - (teams[1].Length - bb)).Reverse()).ToUpper();
                uint[] goals = teams[2].Split(':').Select(uint.Parse).ToArray();
                teamAGoals = goals[0];
                teamBGoals = goals[1];
                input = Console.ReadLine();
                if (teamAGoals == teamBGoals)
                {
                    a = 1;
                    b = 1;
                }
                else if (teamAGoals > teamBGoals)
                {
                    a = 3;
                    b = 0;
                }
                else
                {
                    b = 3;
                    a = 0;
                }

                if (!TeamAndGoals.ContainsKey(teamA))
                {
                    TeamAndGoals.Add(teamA, teamAGoals);
                    TeamAndPoints.Add(teamA, a);
                }
                else
                {
                    TeamAndGoals[teamA] += teamAGoals;
                    TeamAndPoints[teamA] += a;
                }

                if (!TeamAndGoals.ContainsKey(teamB))
                {
                    TeamAndGoals.Add(teamB, teamBGoals);
                    TeamAndPoints.Add(teamB, b);
                }
                else
                {
                    TeamAndGoals[teamB] += teamBGoals;
                    TeamAndPoints[teamB] += b;
                }
            }
            Console.WriteLine("League standings:");
            var place = 0;
            foreach (var team in TeamAndPoints.OrderByDescending(x => x.Value).ThenBy(h =>h.Key))
            {
                place++;
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
            }
            Console.WriteLine("Top 3 scored goals:");
            place = 0;
            foreach (var team in TeamAndGoals.OrderByDescending(x => x.Value).ThenBy(h => h.Key))
            {
                place++;
                if (place > 3)
                { break; }
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}
