using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication207
{
    class Program
    {
        static void Main(string[] args)
        {
           var num = Console.ReadLine();
            
            Console.WriteLine(Reverse(num));

        }
        static string Reverse(string text)
        {

            char[] cArray = text.ToCharArray();

            string reverse = "";

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
