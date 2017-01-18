using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqares = double.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            double made = ((sqares * grape) * 0.4)/2.5;

            if (made > wine)
            {
                double madee = Math.Floor(made);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", madee);
                double leftover = (made - wine);
                leftover = Math.Ceiling(leftover);
                double perperson = leftover / workers;
                perperson = Math.Ceiling(perperson);
                Console.WriteLine("{0} liters left -> {1} liters per person.", leftover, perperson);
            }
            else if (made < wine)
            {
                double needed = wine - made;
                needed = Math.Floor(needed);
                Console.WriteLine("It will be a tought winter! More {0} liters wine needed.", needed);

            }
            else if (made == wine)
                Console.WriteLine("The wine is just enough");
            else
                Console.WriteLine("wrong input");
        }
    }
}
