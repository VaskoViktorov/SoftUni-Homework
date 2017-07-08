using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    class Program
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            string[] busInfo = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] info = Console.ReadLine().Split();
                try
                {
                    switch (info[0])
                    {
                        case "Drive":

                            if (info[1] == "Car")
                            {
                                Console.WriteLine(car.Distance(double.Parse(info[2])));
                            }
                            else if (info[1] == "Truck")
                            {
                                Console.WriteLine(truck.Distance(double.Parse(info[2])));
                            }
                            else if (info[1] == "Bus")
                            {                               
                                Console.WriteLine(bus.Distance(double.Parse(info[2]), true));
                            }
                            break;

                        case "DriveEmpty":

                            Console.WriteLine(bus.Distance(double.Parse(info[2])));
                            break;

                        case "Refuel":

                            if (info[1] == "Car")
                            {
                                car.Refuel(double.Parse(info[2]));
                            }
                            else if (info[1] == "Truck")
                            {
                                truck.Refuel(double.Parse(info[2]));
                            }
                            else if (info[1] == "Bus")
                            {
                                bus.Refuel(double.Parse(info[2]));
                            }
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine($"{car.ToString()}\n{truck.ToString()}\n{bus.ToString()}");
        }
    }
}
