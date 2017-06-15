using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int startIndex = text.IndexOf("<upcase>");

            while (startIndex != -1)
            {
                int endIndex = text.IndexOf("</upcase>");

                if (endIndex == -1)
                {
                    break;
                }
             
                string upcase = text.Substring(startIndex, endIndex - startIndex + "</upcase>".Length);
                string replaceUpcase = upcase.Replace("<upcase>", "").Replace("</upcase>", "").ToUpper();
                text = text.Replace(upcase, replaceUpcase);
                startIndex = text.IndexOf("<upcase>");
            }

            Console.WriteLine(text);
        }
    }
}
