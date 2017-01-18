using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication114
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = double.Parse(Console.ReadLine());
            var p1 = double.Parse(Console.ReadLine());
            var p2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var p1Time = p1 * h;
            var p2Time = p2 * h;
            var percent1 = p1Time/ (p1Time+p2Time) * 100.0;
            var percent2 = p2Time/ (p1Time + p2Time) * 100.0;
            if (v >= p1Time + p2Time)
                
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%."
                    ,Math.Truncate((p1Time+p2Time)/v*100.0), Math.Truncate(percent1), Math.Truncate(percent2));
            else
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,p1Time+p2Time-v);

        }
    }
}
