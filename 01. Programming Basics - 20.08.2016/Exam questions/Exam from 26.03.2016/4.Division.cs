using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication116
{
    class Program
    {
        static void Main(string[] args)
        {
            double n =   double.Parse(Console.ReadLine());
            double del2 = 0;
            double del3 = 0;
            double del4 = 0;
            for (int i = 0; i <n; i++)               
            {

               var j=double.Parse( Console.ReadLine());
                if (j % 2 == 0)
                {
                    del2 += 1;
                }
                if(j%3==0)
                {
                    del3 += 1;
                }
                if (j % 4 == 0)
                {
                    del4 += 1;
                }
            }
            Console.WriteLine("{0:f2}%",del2/n*100.0);
            Console.WriteLine("{0:f2}%", del3 / n * 100.0);
            Console.WriteLine("{0:f2}%", del4 / n * 100.0);
        }
    }
}
