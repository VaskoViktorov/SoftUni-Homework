using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication120
{
    class Program
    {
        static void Main(string[] args)
        {
            var holydays = int.Parse(Console.ReadLine());
            var workdays = 365 - holydays;
            var playtime = workdays * 63 + holydays * 127;
            var time = Math.Abs(30000 - playtime);
            var h = time / 60;
            var m = time % 60;
            if (playtime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", h, m);
            }
            else if (playtime <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", h, m);
            }


        }
    }
}
