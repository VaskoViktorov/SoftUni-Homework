using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double pipeone = double.Parse(Console.ReadLine());
            double pipetwo = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double filled = pipeone * time + pipetwo * time;
            double pipetimeone = ((pipeone * time) / filled) * 100.0;
            pipetimeone = Math.Truncate(pipetimeone);
            double pipetimetwo = ((pipetwo * time) / filled) * 100.0;
            pipetimetwo = Math.Truncate(pipetimetwo);
            double maxcapacity = (filled / volume) * 100.0;
            maxcapacity = Math.Truncate(maxcapacity);

            
            if (filled <= volume)
                Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", maxcapacity, pipetimeone, pipetimetwo);

            else
            {
                var leftover = filled - volume;
                Console.WriteLine("For {1} hours the pool overflows with {0} liters.", leftover, time);
            }
           
        }
    }
}
