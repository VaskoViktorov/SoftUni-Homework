using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            var holyday = int.Parse(Console.ReadLine());
            var workdays = 365 - holyday;
            var playtime = holyday * 127 + workdays * 63;
            var norm = 30000;

            if (playtime > norm)
            {
                Console.WriteLine("Tom will run away");
                double other = (playtime - norm) / 60.0;
                double h = Math.Truncate(other);
                double m = Math.Round((other - h) * 60);
                Console.WriteLine("{0:f0} hours and {1:f0} minutes more for play", h, m);
            }
            else if (playtime <= norm)
            {
                Console.WriteLine("Tom sleeps well");
                double other = (norm - playtime) / 60.0;
                double h = Math.Truncate(other);
                double m = Math.Round((other - h) * 60);
                Console.WriteLine("{0:f0} hours and {1:f0} minutes less for play", h, m);
            }

        }
    }
}
