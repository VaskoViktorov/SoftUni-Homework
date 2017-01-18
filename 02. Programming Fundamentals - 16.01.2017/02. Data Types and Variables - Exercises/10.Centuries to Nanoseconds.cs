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
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;


            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8}000 nanoseconds",
                century, years, days, hours, minutes, seconds, milliseconds, microseconds, microseconds);
        }
    }
}
