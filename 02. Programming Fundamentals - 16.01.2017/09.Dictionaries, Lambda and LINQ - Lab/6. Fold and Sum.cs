using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication263
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

           int lenght = (num.Length / 2)/2;
            int[] row1left = num.Take(lenght).Reverse().ToArray();
            int[] row1right = num.Skip(lenght*3).Take(lenght).Reverse().ToArray();
            int[] row1 =row1left.Concat(row1right).ToArray();
            int[] row2 = num.Skip(lenght).Take(lenght * 2).ToArray();
            
            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
