using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] delimeters = Console.ReadLine().Split();

        Dictionary<string, long> coffeeQuantity = new Dictionary<string, long>();
        Dictionary<string, string> personalPreference = new Dictionary<string, string>();

        string input = Console.ReadLine();

        while (input != "end of info")
        {
            string[] data;
            if (input.Contains(delimeters[0]))
            {
                data = input.Split(new string[] { delimeters[0] }, StringSplitOptions.RemoveEmptyEntries);
                personalPreference[data[0]] = data[1];
                if (!coffeeQuantity.ContainsKey(data[1]))
                    coffeeQuantity[data[1]] = 0;
            }
            else
            {
                data = input.Split(new string[] { delimeters[1] }, StringSplitOptions.RemoveEmptyEntries);
                if (!coffeeQuantity.ContainsKey(data[0]))
                    coffeeQuantity[data[0]] = 0;
                coffeeQuantity[data[0]] += long.Parse(data[1]);
            }

            input = Console.ReadLine();
        }

        string noneLeft = string.Empty;

        foreach (var coffee in coffeeQuantity)
        {
            if (coffee.Value <= 0)
            {
                noneLeft += $"Out of {coffee.Key}\n";
            }
        }
        input = Console.ReadLine();

        while (input != "end of week")
        {
            string[] data = input.Split();
            coffeeQuantity[personalPreference[data[0]]] -= long.Parse(data[1]);
            if (coffeeQuantity[personalPreference[data[0]]] <= 0)
                noneLeft += $"Out of {personalPreference[data[0]]}\n";
            input = Console.ReadLine();
        }

        Console.Write(noneLeft);

        Console.WriteLine("Coffee Left:");

        foreach (var coffee in coffeeQuantity.OrderByDescending(x => x.Value))
        {
            if (coffee.Value > 0)
            {
                Console.WriteLine($"{coffee.Key} {coffee.Value}");
            }
        }
        Console.WriteLine("For:");

        foreach (var person in personalPreference.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
        {
            if (coffeeQuantity[person.Value] > 0)
            {
                Console.WriteLine($"{person.Key} {person.Value}");
            }
        }
    }
}