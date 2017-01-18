using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var holydays = double.Parse(Console.ReadLine());
            var weekends = double.Parse(Console.ReadLine());

            double result = (48.0 -weekends) * (3.0 / 4.0) + weekends + holydays * (2.0 / 3.0);

            if (type == "leap")
                Console.WriteLine("{0:f0}", Math.Floor((0.15 * result) + result));
            else if (type == "normal")
                Console.WriteLine("{0:f0}", Math.Floor(result));


        }
    }
}
