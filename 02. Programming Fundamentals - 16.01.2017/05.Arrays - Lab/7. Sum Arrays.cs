using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication230
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry =  Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arry1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();                      
            var n =  Math.Max(arry.Length, arry1.Length);
            var sumArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                sumArr[i] = arry[i % arry.Length] + arry1[i % arry1.Length];

            }
            Console.WriteLine(string.Join(" ",sumArr));
            
        }
    }
}
