using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        string input;
        var cats = new List<Cat>();

        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var breed = tokens[0];

            switch (breed)
            {
                case "Siamese":
                    Cat cat = new Siamese
                    {
                        Breed = breed,
                        Name = tokens[1],
                        EarSize = int.Parse(tokens[2])
                    };

                    cats.Add(cat);
                    break;

                case "Cymric":
                    Cat cymric = new Cymric
                    {
                        Breed = breed,
                        Name = tokens[1],
                        FurLength = double.Parse(tokens[2])
                    };

                    cats.Add(cymric);
                    break;

                case "StreetExtraordinaire":
                    Cat streetExtraordinaire = new StreetExtraordinaire
                    {
                        Breed = breed,
                        Name = tokens[1],
                        Decibels = int.Parse(tokens[2])
                    };

                    cats.Add(streetExtraordinaire);
                    break;
            }
        }

        var name = Console.ReadLine();
        var result = cats.Where(c => c.Name == name).FirstOrDefault();

        Console.WriteLine(result.ToString());
    }
}
