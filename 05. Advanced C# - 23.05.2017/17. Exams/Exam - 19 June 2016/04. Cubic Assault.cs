using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> cities = new Dictionary<string, Dictionary<string, long>>();
            Regex reg = new Regex(@"\s+->\s+");
            while (input != "Count em all")
            {
               
                string[] splited = reg.Split(input, 3).ToArray();

                if (!cities.ContainsKey(splited[0]))
                {
                    cities.Add(splited[0], new Dictionary<string, long>{ { "Black", 0 },{ "Green", 0 }, {"Red",0}  });
                }      
                
                cities[splited[0]][splited[1]] += long.Parse(splited[2]);

                if (cities[splited[0]][splited[1]] / 1000000 >= 1 && splited[1] != "Black")
                {                   
                        var newValue = cities[splited[0]][splited[1]] / 1000000;
                        var oldValue = cities[splited[0]][splited[1]] % 1000000;
                        cities[splited[0]][splited[1]] = oldValue;

                        if (splited[1] == "Green")
                        {
                            cities[splited[0]]["Red"] += newValue;

                            if (cities[splited[0]]["Red"] / 1000000 >= 1)
                            {
                                newValue = cities[splited[0]]["Red"] / 1000000;
                                oldValue = cities[splited[0]]["Red"] % 1000000;
                                cities[splited[0]]["Red"] = oldValue;                               
                                cities[splited[0]]["Black"] += newValue;
                                
                            }
                        }
                        else if (splited[1] == "Red")
                        {
                            cities[splited[0]]["Black"] += newValue;                            
                        }                                                                 
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in cities.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var one in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"-> {one.Key} : {one.Value}");
                }
            }
        }
    }
}
