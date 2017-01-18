using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication133
{
    class Program
    {
        static void Main(string[] args)
        {
            var project = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var work = (days - 0.1 * days)*8.0;
            var hardwork = workers * (days * 2.0);
            var total = Math.Floor(work + hardwork);
            if (total >= project)
            {
                Console.WriteLine("Yes!{0} hours left.", total - project);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.",project-total);
            }
        }
    }
}
