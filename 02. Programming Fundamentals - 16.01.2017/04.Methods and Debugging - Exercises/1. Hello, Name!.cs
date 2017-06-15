using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication204
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine(PrintName(name));
        }
        static string PrintName(string name)
        {
           name = $"Hello, {name}!";
            return name;
        }
    }
}
