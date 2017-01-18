using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication126
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitc = double.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());
            var bitcToBGN = bitc * 1168d;
            var yuanToUsd = ((yuan*0.15d)*1.76d);
            
            var toEUR =(yuanToUsd + bitcToBGN)/1.95;
            var toEURcommision = (toEUR * commision)/100;
           
            Console.WriteLine("{0}",toEUR-toEURcommision);
        }
    }
}
