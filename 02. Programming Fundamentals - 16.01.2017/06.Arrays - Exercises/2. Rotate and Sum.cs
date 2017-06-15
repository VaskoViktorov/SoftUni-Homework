using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication236
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] arry =  Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotate = int.Parse(Console.ReadLine());
                
            //Invoke RotateArray and print                 
            foreach (var item in RotateArray(arry,rotate))
            {
                Console.Write($"{item} ");
            }
            
        }

        static int[] RotateArray(int[] arry, int rotate)
        {
            int holder = 0;
            int[] sum = new int[arry.Length];
            for (int j = 0; j < rotate; j++)
            {
                holder = arry[arry.Length - 1];

                for (int i = arry.Length - 1; i > 0; i--)
                {

                    arry[i] = arry[i - 1];
                    sum[i] += arry[i - 1];

                }
                arry[0] = holder;
                sum[0] += holder;
            }
            return sum;
        }
    }
}
