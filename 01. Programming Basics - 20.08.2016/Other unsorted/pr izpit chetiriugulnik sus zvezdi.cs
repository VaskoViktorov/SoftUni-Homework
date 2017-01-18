using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication81
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numofrows = n;
            if (n % 2 == 0)
            {
                numofrows = n - 1;
            }
            Console.WriteLine(new string('%',n*2));
                for (int i = 0; i < numofrows; i++)
                {
                if (i == numofrows / 2)
                { Console.WriteLine("%{0}**{0}%", new string(' ', n-2));
                }
                else
                    Console.WriteLine("%{0}%", new string(' ', n*2-2));
                }
                
                Console.WriteLine(new string('%', n*2));
           
        }
    }
}
