using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication100
{
    class Program
    {
        static void Main(string[] args)
        {
            var albumsEUR = decimal.Parse(Console.ReadLine());
            var priceEUR = decimal.Parse(Console.ReadLine());
            var albumsNA = decimal.Parse(Console.ReadLine());
            var priceNA = decimal.Parse(Console.ReadLine());
            var albumsSA = decimal.Parse(Console.ReadLine());
            var priceSA = decimal.Parse(Console.ReadLine());
            var concerts = decimal.Parse(Console.ReadLine());
            var profitEUR = decimal.Parse(Console.ReadLine());

            var firstProducer = priceEUR * 1.94m *albumsEUR+priceNA*1.72m*albumsNA+priceSA/332.74m*albumsSA;
            var fp = firstProducer - firstProducer * 0.35m;
            var fpFinal = fp - fp * 0.2m;
            var secondProducer = profitEUR * 1.94m * concerts;

            if (secondProducer > 100000)
                secondProducer = secondProducer - secondProducer * 0.15m;

            if (secondProducer>=fpFinal)
                Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.",secondProducer);
            else
                Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.",fpFinal);
        }
    }
}
