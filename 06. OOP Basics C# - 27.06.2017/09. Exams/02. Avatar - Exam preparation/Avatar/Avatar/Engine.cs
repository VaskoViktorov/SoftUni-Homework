
using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private NationsBuilder nations = new NationsBuilder();

    public void Run()
    {
        string[] input = Console.ReadLine().Split();
        List<string> args = new List<string>();
        while (input[0] != "Quit")
        {

            foreach (var arg in input)
            {
                args.Add(arg);
            }
            switch (input[0])
            {
                case "Bender":
                    nations.AssignBender(args);
                    break;
                case "Monument":
                    nations.AssignMonument(args);
                    break;
                case "Status":
                    Console.WriteLine(nations.GetStatus(input[1]));
                    break;
                case "War":
                    nations.IssueWar(input[1]);
                    break;
            }

            input = Console.ReadLine().Split();
            args.Clear();
        }
        Console.WriteLine(nations.GetWarsRecord());
        

    }
}

