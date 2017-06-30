
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] {' ','\n','\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Dictionary<string,Person> persons = new Dictionary<string, Person>();
        while (input[0] !="End")
        {
            if (!persons.ContainsKey(input[0]))
            {
                Person current = new Person();
                current.name = input[0];
                persons.Add(input[0],current);
            }
            switch (input[1])
            {
                case "company":
                    company comp = new company();
                    comp.name = input[2];
                    comp.department = input[3];
                    comp.salary = double.Parse(input[4]);
                    persons[input[0]].Company = comp;
                    break;
                case "pokemon":
                    pokemon poke = new pokemon();
                    poke.name = input[2];
                    poke.type = input[3];                 
                    persons[input[0]].Pokemons.Add(poke);
                    break;
                case "parents":
                    parents parent = new parents();
                    parent.name = input[2];
                    parent.birthday = input[3];
                    persons[input[0]].Parents.Add(parent);
                    break;
                case "children":
                    children child = new children();
                    child.name = input[2];
                    child.birthday = input[3];
                    persons[input[0]].Children.Add(child);
                    break;
                case "car":
                    car car = new car();
                    car.model = input[2];
                    car.speed = input[3];                   
                    persons[input[0]].Car = car;
                    break;
            }
            input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        string person = Console.ReadLine();
       var pers = persons.Where(x => x.Key == person).ToList();
        foreach (var one in pers)
        {
            Console.WriteLine(one.Value.name);
            Console.WriteLine("Company:");
            if (one.Value.Company != null)
            {
                Console.WriteLine($"{one.Value.Company.name} {one.Value.Company.department} {one.Value.Company.salary:f2}");
            }
            Console.WriteLine("Car:");
            if (one.Value.Car != null)
            {
                Console.WriteLine($"{one.Value.Car.model} {one.Value.Car.speed}");
            }           
            Console.WriteLine("Pokemon:");
            if (one.Value.Pokemons != null)
            {
                foreach (var pokemon in one.Value.Pokemons)
                {
                    Console.WriteLine($"{pokemon.name} {pokemon.type}");
                }
            }           
            Console.WriteLine("Parents:");
            if (one.Value.Parents != null)
            {
                foreach (var parent in one.Value.Parents)
                {
                    Console.WriteLine($"{parent.name} {parent.birthday}");
                }
            }            
            Console.WriteLine("Children:");
            if (one.Value.Children != null)
            {
                foreach (var child in one.Value.Children)
                {
                    Console.WriteLine($"{child.name} {child.birthday}");
                }
            }
          
        }
    }
}

