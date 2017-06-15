using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication372
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueElements = new SortedSet<string>();
           
            for (int i = 0; i < num; i++)
            {
                string[] elements = Console.ReadLine().Split();
                foreach (var element in elements)
                {  
                        uniqueElements.Add(element);
                }
                
            }

            foreach (var item in uniqueElements)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
