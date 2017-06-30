
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        
        Dictionary<string,Trainer> trainerss = new Dictionary<string, Trainer>();
        while (input != "Tournament")
        {
            string[] splited = input.Split(new[] {'\n', '\t', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (!trainerss.ContainsKey(splited[0]))
            {
                Trainer trainer = new Trainer();
                trainer.name = splited[0];
                trainerss.Add(splited[0], trainer);
            }
                        
            Pokemon pokemon = new Pokemon();
            pokemon.name = splited[1];
            pokemon.element = splited[2];
            pokemon.health = double.Parse(splited[3]);
            trainerss[splited[0]].pokemons.Add(pokemon);
            

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "End")
        {
            foreach (var trainer in trainerss)
            {
                bool hasElement = false;
                foreach (var pokemon in trainer.Value.pokemons)
                {
                    if (pokemon.element.Equals(input))
                    {
                        trainer.Value.badges += 1;
                        hasElement = true;
                        break;
                    }
                }
                if (!hasElement)
                {
                    foreach (var pokemon in trainer.Value.pokemons)
                    {
                        pokemon.health -= 10;
                        if (pokemon.health <= 0)
                        {
                            pokemon.element = "ForRemove";
                        }
                    }
                }             
            }
            input = Console.ReadLine();
        }
        foreach (var trainer in trainerss.OrderByDescending(x => x.Value.badges))
        {       
            Console.WriteLine($"{trainer.Value.name} {trainer.Value.badges} {trainer.Value.pokemons.Count(x => x.element != "ForRemove")}");
        }
    }
}

