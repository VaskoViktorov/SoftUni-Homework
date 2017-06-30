
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine().Split();
            Car car = new Car();
            car.Model = input[0];
            Engine engine = new Engine();
            engine.EngineSpeed = int.Parse(input[1]);
            engine.EnginePower = int.Parse(input[2]);
            car.Engine = engine;
            Cargo cargo = new Cargo();
            cargo.CargoWeight = int.Parse(input[3]);
            cargo.CargoType = input[4];
            car.Cargo = cargo;
            car.Tires = new List<Tire>();

            for (int j = 0; j < 8; j += 2)
            {
                Tire tire = new Tire();
                tire.TirePressure = double.Parse(input[5 + j]);
                tire.TireAge = double.Parse(input[5 + 1 + j]);
                car.Tires.Add(tire);
            }

            cars.Add(car);
        }

        string request = Console.ReadLine();

        if (request == "fragile")
        {
            foreach (var one in cars)
            {
                var pressure = one.Tires.Select(x => x.TirePressure);
                bool danger = false;
                foreach (var tire in pressure)
                {
                    if (tire < 1)
                    {
                        danger = true;
                        break;
                    }
                }
                if (one.Cargo.CargoType == "fragile" && danger)
                {
                    Console.WriteLine(one.Model);
                }
            }
        }
        else if (request == "flamable")
        {
            foreach (var one in cars)
            {
                if (one.Cargo.CargoType == "flamable" && one.Engine.EnginePower > 250)
                {
                    Console.WriteLine(one.Model);
                }
            }
        }
    }
}

