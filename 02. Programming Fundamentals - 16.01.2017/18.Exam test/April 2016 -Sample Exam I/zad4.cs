using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication343
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine().Split().ToList();
            string byers = Console.ReadLine();
            string[] spliter = new string[3];
            string wantedCar = string.Empty;
            int price = new int();
            int sold = 0;

            while (byers != "End of customers!")
            {
                spliter = byers.Split().ToArray();  
                               
                 wantedCar = (spliter[0][0] + spliter[2]).ToLower();

                if (cars.Contains(wantedCar))
                {
                    price = (int)(char.Parse(spliter[0][0].ToString().ToLower())) * int.Parse(spliter[2]);
                    Console.WriteLine($"Yes, sold for {price}$");
                    cars.Remove(wantedCar);
                    sold++;
                }
                else
                {
                    Console.WriteLine("No");
                }

                byers = Console.ReadLine();             
            }

            Console.WriteLine($"Vehicles left: {string.Join(", ", cars)}\nVehicles sold: {sold}");       
        }
    }
}
