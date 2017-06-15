using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication292
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("input.txt");

            for (int i = 1; i < file.Length; i+=2)
            {
                File.AppendAllText("output.txt", file[i]+"\r\n");
            }
        }
    }
}
