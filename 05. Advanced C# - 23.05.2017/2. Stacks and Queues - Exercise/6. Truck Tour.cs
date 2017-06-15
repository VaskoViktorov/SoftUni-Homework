using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication365
{
    class Program
    {
        static void Main(string[] args)
        {
            long pumps = long.Parse(Console.ReadLine());
            Queue<string> track = new Queue<string>();
            long fuel = 0;
            bool fullRun = false;

            for (long i = 0; i < pumps; i++)
            {
                track.Enqueue(Console.ReadLine());
            }

            for (int j = 0; j < pumps; j++)
            {
                
                foreach (var pump in track)
                {
                    fuel += pump.Split().Select(long.Parse).ToArray()[0];
                    fuel -= pump.Split().Select(long.Parse).ToArray()[1];

                    if (fuel < 0)
                    {
                        fullRun = false;
                        break;
                    }
                    else
                    {
                        fullRun = true;
                    }                
                }
                if (fullRun)
                {
                Console.WriteLine(j);
                break;
                }

                fuel = 0;
                track.Enqueue(track.Dequeue());
            }


        }
    }
}
