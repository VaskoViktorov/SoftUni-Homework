using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication108
{
    class Program
    {
        static void Main(string[] args)
        {
            var testHour = int.Parse(Console.ReadLine());
            var testMin = int.Parse(Console.ReadLine());
            var arriveHour = int.Parse(Console.ReadLine());
            var arriveMin = int.Parse(Console.ReadLine());

            var testTime = testHour * 60 + testMin;
            var arriveTime = arriveHour * 60 + arriveMin;
            var other = testTime - arriveTime;
            var otherother = Math.Abs(other);
            var hour = otherother / 60;
            var min = otherother % 60;
            if (testTime == arriveTime || other <= 30 & other > 0)
            {
                Console.WriteLine("On time");
                if (other <= 30 & other > 0)
                {
                    Console.WriteLine("{0} minutes before the start", other);
                }
            }
            else if (other > 30)
            {
                Console.WriteLine("Early");
                if (other > 59)
                {
                    
                    Console.WriteLine("{0}:{1:00} hours before the start", hour, min);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", otherother);
                }
            }
            else
            {
                Console.WriteLine("Late");

                if (otherother > 59)
                {
                   
                    Console.WriteLine("{0}:{1:00} hours after the start", hour, min);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", otherother);
                }
            }
        }
    }
}
