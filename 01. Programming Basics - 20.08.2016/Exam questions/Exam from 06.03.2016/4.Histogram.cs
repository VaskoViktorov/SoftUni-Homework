using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication109
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 0;
            double under200 = 0.0;
            double under399 = 0.0;
            double under599 = 0.0;
            double under799 = 0.0;
            double above800 = 0.0;
            double j = n;
            for (int i = 0; i < n; i++)
            {

                number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    under200 += 1;
                }
                else if (number >= 200 & number <= 399)
                {
                    under399 += 1;
                }
                else if (number >= 400 & number <= 599)
                {
                    under599 += 1;
                }
                else if (number >= 600 & number <= 799)
                {
                    under799 += 1;
                }
                else if (number >= 800)
                {
                    above800 += 1;
                }
                
            }
            
            double under20 = (under200 / j) * 100.0;
            double under39 = (under399 / j)*100.0;
            double under59 = (under599 / j)*100.0;
            double under79 = (under799 / j)*100.0;
            double above80 = (above800 / j) * 100.0;
            Console.WriteLine("{0:f2}%", under20);
            Console.WriteLine("{0:f2}%", under39);
            Console.WriteLine("{0:f2}%", under59);
            Console.WriteLine("{0:f2}%", under79);
            Console.WriteLine("{0:f2}%", above80);

        }
    }
}
