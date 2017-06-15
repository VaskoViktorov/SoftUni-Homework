using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication231
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (arry.Length > 1)
            {
                int[] condensed = new int[arry.Length - 1];

                for (int i = 0; i < arry.Length - 1; i++)
                {
                    condensed[i] = arry[i] + arry[i + 1];
                }

                arry = condensed;
            }
            Console.WriteLine(arry[0]);
        }
    }
}
