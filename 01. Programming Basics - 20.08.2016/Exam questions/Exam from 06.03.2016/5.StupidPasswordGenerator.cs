using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication112
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (char c = 'a'; c < 'a'+a; c++)
                    {
                        for (char d = 'a'; d < 'a'+a; d++)
                        {
                            for (int e = Math.Max(i, b)+1; e <= n; e++)
                            {
                                Console.Write(i);
                                Console.Write(b);
                                Console.Write(c);
                                Console.Write(d);
                                Console.Write("{0} ",e );
                            }
                        }
                    }
                }
            }
        }
    }
}

