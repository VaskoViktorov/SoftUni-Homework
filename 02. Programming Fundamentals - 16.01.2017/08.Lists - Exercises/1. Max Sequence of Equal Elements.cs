using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication255
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var counter = 1;
            var oldCounter = 1;
            var list = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                    if (counter > oldCounter)
                    {
                        oldCounter = counter;
                        list = i;
                    }
                }
                else
                {
                    counter = 1;

                }
            }

            for (int i = 0; i < oldCounter; i++)
            {
                Console.Write("{0} ", numbers[list - i]);
            }
        }
    }
}
