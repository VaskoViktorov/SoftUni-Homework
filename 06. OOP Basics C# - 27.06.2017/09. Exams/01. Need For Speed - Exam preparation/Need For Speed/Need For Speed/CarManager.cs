using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    private Dictionary<int, Car> registratedCars;
    private Dictionary<int, Race> registratedRaces;
    private Garage garage;

    public CarManager()
    {
        this.registratedCars = new Dictionary<int, Car>();
        this.registratedRaces = new Dictionary<int, Race>();
        this.garage = new Garage();
    }
    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {

        if (type == "Performance")
        {
            PerformanceCar car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            registratedCars.Add(id, car);
        }
        else if (type == "Show")
        {
            ShowCar car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            registratedCars.Add(id, car);
        }
    }

    public string Check(int id)
    {

        var cars = registratedCars.Where(x => x.Key.Equals(id));
        string text = String.Empty;
        foreach (var car in cars)
        {
            text = car.Value.ToString();
        }

        return text;
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {

        if (type == "Casual")
        {
            Race race = new CasualRace(length, route, prizePool);
            registratedRaces.Add(id, race);
        }
        else if (type == "Drag")
        {
            Race race = new DragRace(length, route, prizePool);
            registratedRaces.Add(id, race);
        }
        else if (type == "Drift")
        {
            Race race = new DriftRace(length, route, prizePool);
            registratedRaces.Add(id, race);
        }

    }
    public void Open(int id, string type, int length, string route, int prizePool, int bonus)
    {

        if (type == "TimeLimitRace")
        {
            Race race = new TimeLimitRace(length, route, prizePool, bonus);
            registratedRaces.Add(id, race);
        }
        else if (type == "CircuitRace")
        {
            Race race = new CircuitRace(length, route, prizePool, bonus);
            registratedRaces.Add(id, race);
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!garage.ParkedCars.Contains(registratedCars[carId]))
        {
            if (!registratedRaces[raceId].Participants.Contains(registratedCars[carId]))
                registratedRaces[raceId].Participants.Add(registratedCars[carId]);
        }
    }

    public string Start(int id)
    {
        if (registratedRaces.ContainsKey(id))
        {
            if (registratedRaces[id].Participants.Count != 0)
            {
                Dictionary<Car, int> winners = new Dictionary<Car, int>();
                foreach (var car in registratedRaces[id].Participants)
                {
                    winners.Add(car, int.Parse(registratedRaces[id].PerformancePoints(car)));                   
                }

                StringBuilder text = new StringBuilder();
                text.Append($"{registratedRaces[id].Route} - {registratedRaces[id].Length}\r\n");

                int[] prizes = new int[]
                {
                   (registratedRaces[id].PrizePool * 50)/100,
                   (registratedRaces[id].PrizePool * 30)/100,
                   (registratedRaces[id].PrizePool * 20)/100
                };
                var counter = 0;

                foreach (var car in winners.OrderByDescending(g => g.Value))
                {

                    text.Append($"{counter + 1}. {car.Key.Brand} {car.Key.Model} {car.Value}PP - ${prizes[counter]}");
                    counter++;
                    if (counter == 3)
                    {
                        break;
                    }
                }

                registratedRaces.Remove(id);
                return text.ToString().Trim();
            }
        }
        return "Cannot start the race with zero participants.";
    }

    public void Park(int id)
    {
        if (!registratedRaces.Any(x => x.Value.Participants.Contains(registratedCars[id])))
        {
            garage.ParkedCars.Add(registratedCars[id]);
        }
    }

    public void Unpark(int id)
    {
        if (garage.ParkedCars.Contains(registratedCars[id]))
        {
            garage.ParkedCars.Remove(registratedCars[id]);
        }
    }

    public void Tune(int tuneIndex, string tuneAddOn)
    {
        foreach (var car in garage.ParkedCars)
        {
            car.Tuning(tuneIndex, tuneAddOn);
        }
    }
}

