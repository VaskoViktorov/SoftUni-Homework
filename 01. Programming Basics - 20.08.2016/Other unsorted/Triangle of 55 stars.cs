using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums1To20
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i, k;
            for (i = 1; i <= 10; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
         
        }
        
    }
}
