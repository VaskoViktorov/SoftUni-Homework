using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication222
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arry = new int[n];
            int[] reverse = new int[n];
            var count= 0;
            for (int i = 0; i < n; i++)
            {
                arry[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >= 0; i--)
            {
               
                reverse[count] = arry[i];
                count++;
            }
            Console.WriteLine(string.Join(" ",reverse));
        }
    }
}
