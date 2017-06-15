using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication356
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new[] { ',', ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string demon = string.Empty;
            long health = new long();
            string digitPattern = @"(\+*\-*\d+\.*\d*)";
            decimal multiply = 0;
            decimal divide = 0;
            decimal damage = new decimal();
            Regex reg = new Regex(digitPattern);
            Dictionary<string, Dictionary<long, decimal>> list = new Dictionary<string, Dictionary<long, decimal>>();

            for (int i = 0; i < names.Length; i++)
            {
                demon = names[i];
                string[] symbols = names[i].Split(new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', '+', '-'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string demonsymbols = string.Join("", symbols);

                foreach (char symbol in demonsymbols)
                {
                    if (symbol == '/')
                    {
                        divide ++;
                    }
                    else if (symbol == '*')
                    {
                        multiply ++;
                    }
                    else
                    {
                        health += symbol;
                    }
                }

                MatchCollection nums = reg.Matches(demon);

                foreach (Match a in nums)
                {
                    damage += decimal.Parse(a.Groups[1].ToString());
                }
                for (int j = 0; j < multiply; j++)
                {
                    damage *= 2;

                }
                for (int h = 0; h < divide; h++)
                {
                    damage /= 2;
                }
               
                list.Add(demon, new Dictionary<long, decimal>());
                list[demon].Add(health, damage);
                divide = 0;
                multiply = 0;
                health = 0;
                damage = 0;
            }

           list =  list.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var participant in list)
            {
                Console.Write($"{participant.Key} - ");

                foreach (var stats in participant.Value)
                {
                    Console.Write($"{stats.Key} health, {stats.Value:f2} damage");
                    Console.WriteLine();
                }
            }
        }
    }
}
