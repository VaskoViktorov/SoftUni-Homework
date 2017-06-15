using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication243
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int equals = 0;
           
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[i] - array[j + 1] == num || array[i] - array[j + 1] == -num)
                    {
                        equals++;
                        
                    }
                  
                }

            }
            Console.WriteLine(equals);

        }
    }
}
