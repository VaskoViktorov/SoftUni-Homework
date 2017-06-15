using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication270
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> country_city_population = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] data = input.Split('|');
                string countryName = data[1];
                string cityName = data[0];
                long population = long.Parse(data[2]);

                if (!country_city_population.ContainsKey(countryName))
                {
                    country_city_population.Add(countryName, new Dictionary<string, long>());
                    country_city_population[countryName].Add("total population", 0);
                }



                if (!country_city_population[countryName].ContainsKey(cityName))
                {
                    country_city_population[countryName].Add(cityName, population);
                    country_city_population[countryName]["total population"] += population;
                }
                input = Console.ReadLine();
            }
            List<KeyValuePair<string, long>> countryPopulation = new List<KeyValuePair<string, long>>();

            foreach (KeyValuePair<string, Dictionary<string, long>> item in country_city_population)
            {
                countryPopulation.Add(new KeyValuePair<string, long>(item.Key, country_city_population[item.Key]["total population"]));
            }
            SortedKeyValuePairs(countryPopulation);

            foreach (var item in countryPopulation)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");

                List<KeyValuePair<string, long>> cityPopulation = new List<KeyValuePair<string, long>>();

                foreach (KeyValuePair<string, long> city_population in country_city_population[item.Key])
                {
                    cityPopulation.Add(new KeyValuePair<string, long>(city_population.Key, city_population.Value));
                }
                SortedKeyValuePairs(cityPopulation);

                foreach (var pair in cityPopulation)
                {
                    if (pair.Key != "total population")
                    {
                        Console.WriteLine($"=>{pair.Key}: {pair.Value}");
                    }
                }


            }
        }



        private static void SortedKeyValuePairs(List<KeyValuePair<string, long>> countryPopulation)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < countryPopulation.Count - 1; i++)
                {
                    if (countryPopulation[i].Value < countryPopulation[i + 1].Value)
                    {
                        Swap(countryPopulation, i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        private static void Swap(List<KeyValuePair<string, long>> countryPopulation, int i, int v)
        {
            KeyValuePair<string, long> temp = countryPopulation[i];
            countryPopulation[i] = countryPopulation[v];
            countryPopulation[v] = temp;
        }
    }
}
