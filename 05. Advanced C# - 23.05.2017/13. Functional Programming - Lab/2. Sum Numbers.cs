using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            

            Func<string, List<int>> filther = x => x
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Action<List<int>> result = x => Console.WriteLine($"{x.Count}\n{x.Sum()}");
            
            result(filther(first));







        }
    }
}
