using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            byte[] ascii = Encoding.ASCII.GetBytes(Console.ReadLine());

            foreach (Byte b in ascii)
            {
                Console.Write($"\\u00{b.ToString("X").ToLower()}");                
            }


        }
    }
}
