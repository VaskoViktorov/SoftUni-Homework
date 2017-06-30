
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] carSpec = Console.ReadLine().Split();
            Car car = new Car();
            car.Model = carSpec[0];
            car.Fuel = double.Parse(carSpec[1]);
            car.Consumption = double.Parse(carSpec[2]);
            cars.Add(car);
        }

        string driving = Console.ReadLine();

        while (driving != "End")
        {
            var modelAndDistance = driving.Split();
            var current = cars.Where(c => c.Model.Equals(modelAndDistance[1])).ToList();
            Car result = new Car();

            foreach (var one in current)
            {
                if (Car.HasEnoughFuel(modelAndDistance[2], one))
                {
                    result = Car.UsedFuel(modelAndDistance[2], one);

                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (cars[i].Model.Equals(result.Model))
                        {
                            cars[i] = result;
                            break;
                        }
                    }
                    break;
                }
                Console.WriteLine("Insufficient fuel for the drive");
                break;
            }

            driving = Console.ReadLine();
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Distance}");
        }
    }
}

