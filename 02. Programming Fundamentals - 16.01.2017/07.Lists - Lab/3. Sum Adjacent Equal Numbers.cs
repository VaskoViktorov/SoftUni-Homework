using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication250
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int j = 0; j < list.Count; j++)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i - 1] == list[i])
                    {
                       list.RemoveAt(i-1) ;
                        list[i-1] = list[i-1] * 2;
                    }
                }

            }
            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
