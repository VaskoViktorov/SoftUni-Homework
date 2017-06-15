using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> binary = new Stack<int>();
            if (num == 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                while (num != 0)
                {
                    binary.Push(num % 2);
                    num /= 2;

                }
                while (binary.Count != 0)
                {
                    Console.Write(binary.Pop());
                }
                Console.WriteLine();
            }
        }
    }
}
