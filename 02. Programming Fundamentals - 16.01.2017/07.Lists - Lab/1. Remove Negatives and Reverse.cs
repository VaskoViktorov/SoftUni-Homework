using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication248
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> list =   Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> newList = new List<long>();

            foreach (var item in list)
            {
                if (item > 0)
                {
                    newList.Add(item);
                    
                }
               
            }
            newList.Reverse();

            if (newList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newList));
            }
           
        }
    }
}
