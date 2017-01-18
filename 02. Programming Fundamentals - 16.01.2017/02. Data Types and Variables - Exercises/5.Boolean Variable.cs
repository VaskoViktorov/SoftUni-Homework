using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool a = bool.Parse(text);
            if (a == true)
                Console.WriteLine("Yes");
            else if (a == false)
                Console.WriteLine("No");


        }
    }
}
