using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>(Console.ReadLine()
                
                .Split()
                .ToArray());        
        
            HashSet<string> letters = new HashSet<string>(Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray());

            SortedSet<string> result = new SortedSet<string>();

            foreach (var letter in letters)
            {
                names.Where(w => w.First().ToString().ToLower() == letter).ToList().ForEach(w => result.Add(w));
            }

            if (result.Count != 0)
            {
                Console.WriteLine(result.First());
            }
            else
            {
                Console.WriteLine("No match");
            }




        }
    }
}
