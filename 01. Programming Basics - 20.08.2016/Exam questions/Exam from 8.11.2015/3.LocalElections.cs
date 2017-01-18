using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication88
{
    class Program
    {
        static void Main(string[] args)
        {
            var candidates = int.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());
            string symbol =  Console.ReadLine();
            
            for (int i = 1; i <= candidates; i++)
            {
                Console.WriteLine(".............");
                Console.WriteLine("...+-----+...");
                
                if (i == num && symbol =="V" || i == num && symbol == "v")
                {
                    Console.WriteLine("...|\\.../|...");
                    Console.WriteLine("{0:00}.|.\\./.|...",i);
                    Console.WriteLine("...|..{0}..|...",'V');
                }
                else if (i == num && symbol == "X" || i == num && symbol == "x")
                {
                    Console.WriteLine("...|.\\./.|...");
                    Console.WriteLine("{0:00}.|..{1}..|...", i, 'X');
                    Console.WriteLine("...|./.\\.|...");
                }
                else
                {
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0:00}.|.....|...",i);
                    Console.WriteLine("...|.....|...");
                }
                
                Console.WriteLine("...+-----+...");
                
            }
            Console.WriteLine(".............");

        }
    }
}
