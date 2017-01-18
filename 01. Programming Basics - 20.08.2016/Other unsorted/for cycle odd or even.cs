using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            var odd = 0;
            var even = 0;
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var sum = int.Parse(Console.ReadLine());

                if (i%2 == 0)
                {
                    odd +=sum;
                }
                else
                {
                    even += sum;
                }
            }
            if (odd == even)
                Console.WriteLine("Yes sum = {0}", odd); 
            else
                Console.WriteLine("No diff = {0}", Math.Abs(odd - even));
        }
    }
}
