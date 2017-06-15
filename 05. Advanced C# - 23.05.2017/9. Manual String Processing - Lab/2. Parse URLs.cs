using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string separator = "://";
            string[] url = input.Split(new[] {separator}, StringSplitOptions.RemoveEmptyEntries);
                       
            if (url.Length != 2 || url[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                string protocol = url[0];
                var indexResource = url[1].IndexOf('/');
                string server = url[1].Substring(0, indexResource);
                string resources = url[1].Substring(indexResource+1);
                Console.WriteLine("Protocol = {0}\nServer = {1}\nResources = {2}", protocol, server, resources);
            }
            
            

        }
    }
}
