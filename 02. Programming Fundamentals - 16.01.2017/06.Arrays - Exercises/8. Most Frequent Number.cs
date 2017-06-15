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
            int leftSum = 0;
            int rightSum = 0;
            int no = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    
                        leftSum += array[j];
                                                                                      
                }
                for (int h = array.Length-1; h > i; h--)
                {
                    rightSum += array[h];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    no++;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (no == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
