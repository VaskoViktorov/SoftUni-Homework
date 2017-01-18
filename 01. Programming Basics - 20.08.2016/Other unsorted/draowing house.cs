using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var straws = (n - 1) / 2;
            var otherstraws = 1;
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
                otherstraws = 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', straws), new string('*', stars));

            for (int i = 1; i <= (n - 1) / 2; i++)
            {

                Console.WriteLine("{0}*{1}*{0}", new string('-', straws - 1), new string('-', otherstraws));
                straws--;
                otherstraws += 2;
            }

            straws = 1;
            otherstraws = n - 4;

            for (int g = 1; g < (n - 1) / 2; g++)
            {

                Console.WriteLine("{0}*{1}*{0}", new string('-', straws), new string('-', otherstraws));

                straws++;
                otherstraws -= 2;
            }
            

                if (n >= 3)
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', stars));
            
        }
    }

}
