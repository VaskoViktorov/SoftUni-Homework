using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = decimal.Parse(Console.ReadLine());

            if (type >= 100 & type <= 200 || type == 0)
                Console.WriteLine();

            else
                Console.WriteLine("invalid");

            


        }
    }
}
