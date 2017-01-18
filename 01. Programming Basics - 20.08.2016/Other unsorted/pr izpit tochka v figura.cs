using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication72
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if (x>=4 && y >=-5 && x<=10 && y <=3)
                Console.WriteLine("in");
            else if ( x>=2 && y>=-3 && x<=12 && y<=1)
                Console.WriteLine("in");
            else
                Console.WriteLine("out");
        }
    }
}
