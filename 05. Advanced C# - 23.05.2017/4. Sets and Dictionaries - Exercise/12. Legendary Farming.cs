using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication381
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            SortedDictionary<string, long> legendary = new SortedDictionary<string, long>
            {
                {"fragments", 0},
                {"shards", 0},
                {"motes", 0}
            };
            SortedDictionary<string, long> trash = new SortedDictionary<string, long>();
            bool LegendaryAquired = false;
            while (!LegendaryAquired)
            {
                string[] loot = Console.ReadLine().Split(' ').ToArray();

                for (int i = 0; i < loot.Length; i += 2)
                {
                    long amaunt = long.Parse(loot[i]);
                    string type = loot[i + 1].ToLower();

                    if (legendary.ContainsKey(type))
                    { 
                        legendary[type] += amaunt;
                                                   
                        if (legendary[type] >= 250)
                        {
                            LegendaryAquired = true;
                            legendary[type] -= 250;
                            if (type == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (type == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            break;                           
                        }
                    }
                    else
                    {
                        if (!trash.ContainsKey(type))
                        {
                            trash.Add(type, amaunt);
                        }
                        else
                        {
                            trash[type] += amaunt;
                        }
                    }

                }      
            }
            foreach (var item in legendary.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in trash)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
