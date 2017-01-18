using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var greater = Math.Max(a,b);
            var lesser = Math.Min(a,b);

            while (lesser != 0)
            {
                var reminder = greater % lesser;
                greater = lesser;
                lesser = reminder;
            }
            Console.WriteLine(greater);
        }
    }
}
