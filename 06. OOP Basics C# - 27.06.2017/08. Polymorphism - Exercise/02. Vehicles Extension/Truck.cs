using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Refuel(double addedFuel)
        {
            if (addedFuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += (addedFuel * 0.95d);
        }

        public override string Distance(double distanceToTravel)
        {
            var neededFuel = (this.FuelConsumption + 1.6d) * distanceToTravel;

            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException("Truck needs refueling");
            }
           
            this.FuelQuantity -= neededFuel;

            return $"Truck travelled {distanceToTravel} km";
        }

        public override string Distance(double distanceToTravel, bool hasPeople)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}
