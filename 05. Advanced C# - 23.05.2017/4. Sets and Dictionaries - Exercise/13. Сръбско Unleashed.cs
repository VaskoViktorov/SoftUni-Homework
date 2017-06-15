using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication382
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string input = Console.ReadLine();
            string pattern = @"^(.+)\s@([\D]+)\s([\d]+)\s([\d]+)$";
            Regex reg = new Regex(pattern);            
            Dictionary<string,Dictionary<string,int>> concerts = new Dictionary<string, Dictionary<string, int>>();

            //matching and adding to dictionary
            while (input != "End")
            {
                if (reg.IsMatch(input))
                {
                    Match info = reg.Match(input);
                    string singer = info.Groups[1].ToString();
                    string place = info.Groups[2].ToString();
                    int money = int.Parse(info.Groups[3].ToString()) * int.Parse(info.Groups[4].ToString());

                    if (!concerts.ContainsKey(place))
                    {
                        concerts.Add(place, new Dictionary<string, int>());
                    }
                    if (!concerts[place].ContainsKey(singer))
                    {
                        concerts[place].Add(singer, 0);
                    }
                    concerts[place][singer] += money;
                }
                input = Console.ReadLine();
            }

            //output
            foreach (var location in concerts)
            {
                Console.WriteLine(location.Key);
                foreach (var entertainer in location.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {entertainer.Key} -> {entertainer.Value}");
                }
            }
        }
    }
}
