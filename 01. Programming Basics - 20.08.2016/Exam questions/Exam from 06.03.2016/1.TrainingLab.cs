using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication106
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var height = Math.Floor(((h*10) - 10d)/7d);
            var lenght = Math.Floor((w * 10) / 12);
            var sum = height * lenght - 3;
            Console.WriteLine(sum);
        }

    }
}
