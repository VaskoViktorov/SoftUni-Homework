using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose input file path: ");
            var readFilePath = Console.ReadLine();
            Console.Write("Choose output file path: ");
            var writeFilePath = Console.ReadLine();

            using (StreamReader reader = new StreamReader(readFilePath))
            {

                using (StreamWriter writer = new StreamWriter(writeFilePath))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    
                    while (line != null)
                    {
                        lineNumber++;

                        writer.WriteLine("{0} {1}", lineNumber, line);
                                               
                        line = reader.ReadLine();
                    }
                }              
            }
        }
    }
}
