using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication153
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(num, 16).ToUpper();
            string binary = Convert.ToString(num, 2).ToUpper();

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);




        }
    }
}
