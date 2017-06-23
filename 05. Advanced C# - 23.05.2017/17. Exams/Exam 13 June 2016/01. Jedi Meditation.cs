using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<string> masters = new Queue<string>();
            Queue<string> knights = new Queue<string>();
            Queue<string> padwans = new Queue<string>();
            Queue<string> theGuys = new Queue<string>();
            bool yoda = false;
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j][0] == 'm')
                    {
                        masters.Enqueue(input[j]);
                    }
                    else if (input[j][0] == 'k')
                    {
                        knights.Enqueue(input[j]);
                    }
                    else if (input[j][0] == 'p')
                    {
                        padwans.Enqueue(input[j]);
                    }
                    else if (input[j][0] == 's' || input[j][0] == 't'|| input[j][0] == 'y')
                    {
                        if (input[j][0].ToString().ToLower() == "y")
                        {
                            yoda = true;
                        }
                        else
                        {
                            theGuys.Enqueue(input[j]);
                        }
                        
                    }
                }
            }
            var result = masters.Union(knights);

            if (!yoda)
            {
                foreach (var guy in theGuys)
                {
                    
                        Console.Write($"{guy} ");
                    
                }
                foreach (var jedi in result)
                {
                    Console.Write($"{jedi} ");
                }
                foreach (var padwan in padwans)
                {
                    Console.Write($"{padwan} ");
                }
            }
            else
            {                          
                foreach (var jedi in result)
                {
                    Console.Write($"{jedi} ");
                }
                foreach (var guy in theGuys)
                {
                   
                        Console.Write($"{guy} ");
                    
                }
                foreach (var padwan in padwans)
                {
                    Console.Write($"{padwan} ");
                }
            }
        }
    }
}
