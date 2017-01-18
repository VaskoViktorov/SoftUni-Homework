using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var ent = Console.ReadLine();
            var ext = Console.ReadLine();

            var BGN = 1.00;
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;
          
            switch (ent)
            {
                case "BGN":
                    break;
                case "USD":
                    sum = sum * USD;
                    break;
                case "EUR":
                    sum = sum * EUR;
                    break;
                case "GBP":
                    sum = sum * GBP;
                    break;
                default:
                    break;
            }
            switch (ext)
            {
                case "BGN":
                    sum = sum / BGN;
                    break;
                case "USD":
                    sum = sum / USD;
                    break;
                case "EUR":
                    sum = sum / EUR;
                    break;
                case "GBP":
                    sum = sum / GBP;
                    break;
                default:
                    break;
            }
            Console.WriteLine(Math.Round(sum, 2) + " " + ext);
        }
    }
}
