using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Refuel(double addedFuel)
        {
            if (addedFuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + addedFuel > this.tankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.FuelQuantity += addedFuel;
        }

        public override string Distance(double distanceToTravel)
        {
            var neededFuel = (this.FuelConsumption) * distanceToTravel;
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException("Bus needs refueling");
            }
            this.FuelQuantity -= neededFuel;
            return $"Bus travelled {distanceToTravel} km";
        }

        public override string Distance(double distanceToTravel, bool hasPeople)
        {
            var extraNeeded = 0d;
            if (hasPeople)
            {
                extraNeeded = 1.4d;
            }
            var neededFuel = (this.FuelConsumption+ extraNeeded) * distanceToTravel;
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException("Bus needs refueling");
            }
            this.FuelQuantity -= neededFuel;
            return $"Bus travelled {distanceToTravel} km";
        }

        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:f2}";
        }
    }
}
