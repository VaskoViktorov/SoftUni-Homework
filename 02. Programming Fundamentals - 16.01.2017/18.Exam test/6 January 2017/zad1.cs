using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication323
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime LeaveTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            BigInteger steps = BigInteger.Parse(Console.ReadLine());
            BigInteger timePerStep = BigInteger.Parse(Console.ReadLine());
            steps = steps * timePerStep;

            BigInteger sec = steps % 60;
            BigInteger min = steps / 60 % 60;
            BigInteger hour = steps / 60 / 60 % 24;

            LeaveTime =LeaveTime.AddHours((double)hour);
            LeaveTime = LeaveTime.AddMinutes((double)min);
            LeaveTime = LeaveTime.AddSeconds((double)sec);

            Console.WriteLine($"Time Arrival: {LeaveTime.Hour:00}:{LeaveTime.Minute:00}:{LeaveTime.Second:00}");
        }
    }
}
