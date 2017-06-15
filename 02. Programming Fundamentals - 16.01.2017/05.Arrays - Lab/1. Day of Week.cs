using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication221
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] arry = { "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", " Sunday" };
            
            if (day > 7 || day < 0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(arry[day]);
            }
        }
    }
}
