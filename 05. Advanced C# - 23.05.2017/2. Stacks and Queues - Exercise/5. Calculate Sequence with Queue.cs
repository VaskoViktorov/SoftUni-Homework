using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            queue.Enqueue(num);

            for (int i = 0; i < 16; i++)
            {
                    long j = queue.Peek();
                    queue.Enqueue(j + 1);
                    queue.Enqueue(2 * j + 1);
                    queue.Enqueue(j + 2);
                    long n = queue.Dequeue();
                    Console.Write($"{n} "); 
            }
            queue.Enqueue(queue.Peek() + 1);

            while(queue.Count != 0)
            { 
                Console.Write($"{queue.Dequeue()} ");
            }
        }
    }
}
