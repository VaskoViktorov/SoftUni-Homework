using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication149
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());

            float time = hours * 3600f + min * 60f + sec;
            float miles = distance / 1609f;

            float metersPS = distance / time;
            float kilometersPS = (distance / 1000f) / (time / 3600f);
            float milesPS = miles / (time / 3600f);

            Console.WriteLine("{0}", metersPS);
            Console.WriteLine("{0}", kilometersPS);
            Console.WriteLine("{0}", milesPS);
        }
    }
}