using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication348
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split().ToArray();
            decimal[] track = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).Select(x => Math.Abs(x)).ToArray();
            decimal startFuel = new decimal();
            List<string> result = new List<string>();

            for (int i = 0; i < drivers.Length; i++)
            {
                startFuel = drivers[i][0];
                for (int j = 0; j < track.Length; j++)
                {
                    if (checkpoints.Contains(j))
                    {
                        startFuel += track[j];
                    }
                    else
                    {
                        startFuel -= track[j];
                    }
                    if (startFuel <= 0)
                    {
                        result.Add($"{drivers[i]} - reached {j}");
                        break;
                    }
                }
                if (startFuel > 0)
                {
                    result.Add($"{drivers[i]} - fuel left {startFuel:f2}");
                }

            }
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
