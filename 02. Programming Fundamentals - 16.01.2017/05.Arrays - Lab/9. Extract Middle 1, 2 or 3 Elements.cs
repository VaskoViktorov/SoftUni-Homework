using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication233
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (arry.Length == 1)
            {
                Console.WriteLine($"{{ {arry[0]} }}");
            }
            else if (arry.Length % 2 == 1)
            {
                Console.WriteLine($"{{ {arry[arry.Length/2-1]} }},{{ {arry[arry.Length / 2]} }},{{ {arry[arry.Length / 2 + 1]} }}");
            }
            else if (arry.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {arry[arry.Length / 2 - 1]} }},{{ {arry[arry.Length / 2]} }}");
            }
        }
    }
}
