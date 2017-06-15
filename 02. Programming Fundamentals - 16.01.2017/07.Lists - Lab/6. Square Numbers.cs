using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication253
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> sqrtList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {           
                if (Math.Sqrt(list[i]) == (int)Math.Sqrt(list[i]))
                {
                    sqrtList.Add((int) list[i]);
                }
            }
            sqrtList.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",sqrtList)); 
        }
    }
}
