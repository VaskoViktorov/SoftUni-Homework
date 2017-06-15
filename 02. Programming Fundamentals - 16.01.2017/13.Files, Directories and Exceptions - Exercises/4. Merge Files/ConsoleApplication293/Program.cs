using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication293
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = File.ReadAllLines("Input1.txt");
            string[] input2 = File.ReadAllLines("Input2.txt");
            string[] input = input1.Concat(input2).OrderBy(x=>x).ToArray();


            File.AppendAllLines("Output.txt", input);
        }
    }
}
