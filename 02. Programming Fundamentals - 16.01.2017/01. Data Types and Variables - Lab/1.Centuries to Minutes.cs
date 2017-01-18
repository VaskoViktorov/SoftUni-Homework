using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication148
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            int years = century * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;




            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                century, years, days, hours, minutes);
        }
    }
}
