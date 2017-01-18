using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication124
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dots = n;
            var lines = n * 2 - 1;
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n * 2 + 1));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', lines));
                dots--;
                lines += 2;
                if (i == n)
                {
                    Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', lines / 2 - 2));
                    Console.WriteLine("\\\\{0}//", new string('_', lines));
                }
            }
            dots = 1;
            lines -= 2;

            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', lines));
                dots++;
                lines -= 2;

            }
        }
    }
}
