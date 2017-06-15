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
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<string> partOne = new HashSet<string>();
            HashSet<string> partTwo = new HashSet<string>();
            for (int i = 0; i < num[0]; i++)
            {
                string firstNum = Console.ReadLine();
                partOne.Add(firstNum);
            }
            for (int i = 0; i < num[1]; i++)
            {
                string secondNum = Console.ReadLine();
                partTwo.Add(secondNum);
            }
            partOne.IntersectWith(partTwo);
            foreach (var item in partOne)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
