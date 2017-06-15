using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication369
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> guests = new SortedSet<string>();
            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                guests.Add(input);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                guests.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(guests.Count);
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
