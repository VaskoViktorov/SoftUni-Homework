using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication237
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            int[] firstPart = new int[(arry.Length / 2)/ 2];
            int[] secondPart = new int[(arry.Length / 2) / 2];
            int[] midPart = new int[(arry.Length / 2)];


            
            for (int i = 0; i < (arry.Length / 2) / 2; i++)
            {
                firstPart[i] = arry[i];
                secondPart[i] = arry[(arry.Length-1) - i];                              
            }
            Array.Reverse(firstPart);
            

            if (arry.Length <= 4)
            {
                midPart[0] = arry[1];
                midPart[1] = arry[2];
            }
            else
            {
                for (int i = 0; i <arry.Length / 2; i++)
                {
                    midPart[i] = arry[i + (arry.Length/ 2)/2];
                }
            }

            for (int i = 0; i < (arry.Length / 2) / 2; i++)
            {
                midPart[i] += firstPart[i];
                midPart[i+ (midPart.Length/ 2)] += secondPart[i];
            }

            foreach (var item in midPart)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
