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
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] info = Console.ReadLine().Split();
                switch (info[0])
                {
                    case "Drive":
                        try
                        {
                            if (info[1] == "Car")
                            {
                                Console.WriteLine(car.Distance(double.Parse(info[2])));                              
                            }
                            else if (info[1] == "Truck")
                            {
                                Console.WriteLine(truck.Distance(double.Parse(info[2])));                        
                            }
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
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
                        break;
                }
            }
            Console.WriteLine($"{car.ToString()}\n{truck.ToString()}");
        }
    }
}
