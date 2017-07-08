using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Refuel(double addedFuel)
        {
            this.FuelQuantity += addedFuel;
        }

        public override string Distance(double distanceToTravel)
        {
            var neededFuel = (this.FuelConsumption + 0.9d) * distanceToTravel;
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException("Car needs refueling");
            }           
            this.FuelQuantity -= neededFuel;
            return $"Car travelled {distanceToTravel} km";
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }
    }
}
