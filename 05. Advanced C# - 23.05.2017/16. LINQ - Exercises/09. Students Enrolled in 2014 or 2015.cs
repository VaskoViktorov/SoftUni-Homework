using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"14$|15$");
            List<string> list= new List<string>(); 
            while (input != "END")
            {
                string[] arr = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (reg.IsMatch(arr[0]))
                {
                    list.Add(string.Join(" ",arr.Skip(1)));
                }
                
                input = Console.ReadLine();
            }

            foreach (var grades in list)
            {
                Console.WriteLine($"{grades}");
            }
        }
    }

   
}