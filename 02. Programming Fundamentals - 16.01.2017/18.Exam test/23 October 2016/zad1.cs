using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication318
{
    class Program
    {
        static void Main(string[] args)
        {
           
            short days = short.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            byte laps = byte.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            short trackCapacity = short.Parse(Console.ReadLine());
            decimal cashPerKm = decimal.Parse(Console.ReadLine());

            runners = runners > trackCapacity * days ? trackCapacity * days : runners;
                      
            Console.WriteLine("Money raised: {0:f2}", ((trackLength / 1000m) * laps * runners) * cashPerKm);
        }
    }
}
