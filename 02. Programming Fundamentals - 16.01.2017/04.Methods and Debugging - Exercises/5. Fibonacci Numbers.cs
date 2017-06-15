using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication208
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            Console.WriteLine(Fibunacci(n)); 
        }
        static long Fibunacci(long n)
            {
            var result = 0;
            var a = 0;
            var b = 1;
            for (int i = 0; i < n; i++)
            {
                
                result = b+a;
                a = b;
                b = result;
              
            }
            if (n == 0)
            {
                result = 1;
            }
            return result; 
            }
    }
}
