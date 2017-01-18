using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication137
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var no = int.Parse(n);
            var first = int.Parse(n.Substring(0, 1));
            var second = int.Parse(n.Substring(1, 1));
            var third = int.Parse(n.Substring(2, 1));
            var rows = first+second;
            var numbers = first +third;
            var j = no;
            for (int i = 0; i < rows; i++)
            {
                for (int x = 0; x < numbers; x++)
                {
                    if (j % 5 == 0)
                    {
                        j -= first;
                    }
                    else if (j % 3 == 0)
                    {
                        j -= second;
                    }
                    else
                    {
                        j +=third;
                    }
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }
    }
}
