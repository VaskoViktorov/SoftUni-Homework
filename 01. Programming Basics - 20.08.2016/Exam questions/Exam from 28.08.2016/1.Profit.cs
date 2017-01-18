using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication132
{
    class Program
    {
        static void Main(string[] args)
        {
            var workdays = double.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());
            var course = double.Parse(Console.ReadLine());
            var yearworth = workdays * money * 12 + workdays * money *2.5;
            var l = yearworth * 0.25;
            var net = yearworth - l;
            var dayworth = net / 365*course;
            Console.WriteLine("{0:f2}",dayworth);
        }
    }
}
