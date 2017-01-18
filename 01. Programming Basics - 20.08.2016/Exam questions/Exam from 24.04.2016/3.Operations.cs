using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication121
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var opr = Console.ReadLine();
            var result = 0.0;
            var j = "nul";
            if (n1 == 0)
                Console.WriteLine("Cannot divide {0} by zero", n2);
            else if (n2 == 0)
                Console.WriteLine("Cannot divide {0} by zero", n1);
            else
            {
                if (opr == "+")
                {
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        j = "even";
                    }
                    else
                    {
                        j = "odd";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, opr, n2, result, j);
                }
                else if (opr == "-")
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        j = "even";
                    }
                    else
                    {
                        j = "odd";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, opr, n2, result, j);
                }

                else if (opr == "*")
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        j = "even";
                    }
                    else
                    {
                        j = "odd";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, opr, n2, result, j);
                }
                else if (opr == "/")
                {
                    result = n1 / n2;
                    
                    Console.WriteLine("{0} {1} {2} = {3:f2}", n1, opr, n2, result);
                }
                else if (opr == "%")
                {
                    result = n1 % n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, opr, n2, result);
                }
                
            }
        }
    }
}
