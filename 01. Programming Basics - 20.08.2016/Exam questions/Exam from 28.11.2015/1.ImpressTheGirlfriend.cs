using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication96
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = decimal.Parse(Console.ReadLine());
            var d = decimal.Parse(Console.ReadLine());
            var e = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());
                var rub = (r/100m)*3.5m;
                var usd = d * 1.5m;
                var eur = e * 1.95m;
                var lv1in2 = b / 2;

            var biggest = Math.Max(rub, usd);
            var bigger = Math.Max(eur, lv1in2);
            var big = Math.Max(m, biggest);
            Console.WriteLine("{0:f2}",Math.Ceiling(Math.Max(big, bigger))); 


        }
    }
}
