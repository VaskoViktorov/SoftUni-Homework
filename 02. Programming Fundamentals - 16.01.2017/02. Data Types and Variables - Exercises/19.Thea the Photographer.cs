using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication159
{
    class Program
    {
        static void Main(string[] args)
        {

            var picturesCount = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterPercentage = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            long filterSeconds = (long)picturesCount * filterTime;
            long goodPictures = (long)Math.Ceiling(picturesCount * ((double)filterPercentage / 100));
            long uploadSeconds = goodPictures * uploadTime;

            long totalSeconds = (long)(filterSeconds + uploadSeconds);
            TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);



            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }
    }
}
