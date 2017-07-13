using System;
using System.Linq;

public class Engine
{
    private CarManager manager = new CarManager();

    public void Run()
    {
        string[] input = Console.ReadLine().Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        while (input[0] != "Cops")
        {

            switch (input[0].ToLower())
            {
                case "register":
                    manager.Register(int.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5]),
                          int.Parse(input[6]), int.Parse(input[7]), int.Parse(input[8]), int.Parse(input[9]));
                    break;
                case "check":
                    Console.WriteLine(manager.Check(int.Parse(input[1])));
                    break;
                case "open":
                    if (input[1] == "CircuitRace" || input[1] == "TimeLimitRace")
                    {
                        manager.Open(int.Parse(input[1]), input[2], int.Parse(input[3]), input[4], int.Parse(input[5]), int.Parse(input[6]));
                    }
                    else
                    {
                        manager.Open(int.Parse(input[1]), input[2], int.Parse(input[3]), input[4], int.Parse(input[5]));
                    }
                    break;
                case "participate":
                    manager.Participate(int.Parse(input[1]), int.Parse(input[2]));
                    break;
                case "start":
                    Console.WriteLine(manager.Start(int.Parse(input[1])));
                    break;
                case "park":
                    manager.Park(int.Parse(input[1]));
                    break;
                case "unpark":
                    manager.Unpark(int.Parse(input[1]));
                    break;
                case "tune":
                    manager.Tune(int.Parse(input[1]), string.Join(" ",input.Skip(2).ToArray()));
                    break;

            }
            input = Console.ReadLine().Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}

