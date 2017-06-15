using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication329
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long secPerPic = long.Parse(Console.ReadLine());
            long GoodPicPerct = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            
            long filterTime = secPerPic * pictures;
            double newPictures = Math.Ceiling(pictures * GoodPicPerct / 100d);
            long upload =uploadTime * long.Parse(newPictures.ToString());
            TimeSpan time = TimeSpan.FromSeconds(filterTime+upload);
                     
            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));



        }
    }
}
