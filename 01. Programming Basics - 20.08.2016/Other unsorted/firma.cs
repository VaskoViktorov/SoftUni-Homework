using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            var project = int.Parse(Console.ReadLine());
            var avtime = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var time = Math.Floor((avtime - avtime * 0.1) * 8.0 + (avtime*2.0) * workers);

            if (project <= time)
                Console.WriteLine("Yes!{0} hours left.", time - project);
            else
                Console.WriteLine("Not enough time!{0} hours needed.", project - time);
        }
    }
}
