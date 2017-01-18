using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication163
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = persons / capacity;
            if (persons % capacity != 0)
            {
                courses += 1;
            }

            Console.WriteLine(courses);
        }
    }
}
