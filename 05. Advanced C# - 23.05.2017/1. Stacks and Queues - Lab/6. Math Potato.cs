using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int num = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);
            int cycle = 1;
            while (kids.Count != 1)
            {
                for (int i = 0; i < num -1; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }

                if (PrimeTool.isPrime(cycle))
                {
                    Console.WriteLine($"Prime {kids.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {kids.Dequeue()}");
                }
                cycle++;
                
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");

        }

        public static class PrimeTool
        {
            public static bool isPrime(int candidate)
            {
                if((candidate & 1) == 0)
                {
                    if(candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                for (int i = 3; (i*i) <= candidate; i+=2)
                {
                    if ((candidate%i)==0)
                    {
                        return false;
                    }

                }
                return candidate != 1;
            }
        }
    }
}
