using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication130
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var outerdots = n-1;
            var innerdots = n*3;
            Console.WriteLine("{0}{1}{0}",new string('.', n),new string('*',3*n));
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.',outerdots),new string('.', innerdots));
                outerdots--;
                innerdots += 2;
            }
            Console.WriteLine(new string('*',n*5));
            outerdots = 1;
            innerdots -= 2;
            for (int i = 1; i <= n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerdots), new string('.', innerdots));
                outerdots++;
                innerdots -= 2;
            }
            Console.WriteLine("{0}{1}{0}",new string('.',n*2+1),new string('*', n-2));
        }
    }
}
