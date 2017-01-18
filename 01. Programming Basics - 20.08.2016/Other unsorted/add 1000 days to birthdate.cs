using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoledate = Console.ReadLine();
            var format = "dd-MM-yyyy";
            
            var  result = DateTime.ParseExact(consoledate, format, null);
                DateTime answer = result.AddDays(999);

            Console.WriteLine(answer.ToString("dd-MM-yyyy"));
           
            
        }
    }
}
 