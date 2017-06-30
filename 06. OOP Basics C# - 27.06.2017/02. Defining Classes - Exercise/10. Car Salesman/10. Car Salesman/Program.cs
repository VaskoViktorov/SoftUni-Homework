
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();
        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Engine eng = new Engine();
            eng.model = input[0];
            eng.power = input[1];

            if (input.Length == 3)
            {                
                int a = 0;
                int.TryParse(input[2], out a);
                if (a == 0)
                {
                    eng.efficiency = input[2];
                   
                }
                else
                {
                    eng.displacement = input[2];
                }
            }
            else if (input.Length == 4)
            {
                eng.displacement = input[2];
                eng.efficiency = input[3];
            }        
            engines.Add(eng);
        }

        num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine().Split(new []{' ','\t','\n'},StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car();
            car.model = input[0];
            foreach (var engine in engines)
            {
                if (engine.model.Equals(input[1]))
                {
                    car.engine = engine;
                    break;
                }
            }
            if (input.Length == 3)
            {
                int a = 0;
                int.TryParse(input[2], out a);
                if (a == 0)
                {
                    car.Color = input[2];
                }
                else
                {
                    car.Weight = input[2];
                }
                
            }
            else if (input.Length == 4)
            {
                car.Weight = input[2];
                car.Color = input[3];
            }
            cars.Add(car);
        }
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }

    }
}

