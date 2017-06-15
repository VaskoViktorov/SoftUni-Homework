using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose file path: ");
            var filePath = Console.ReadLine();

            using (StreamReader reader = new StreamReader(filePath))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }


            }
        }
    }
}
