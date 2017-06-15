using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>();
            
            for (int i = input.Length-1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }
            while (stack.Count != 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var oper = stack.Pop();
                var secondtNum = int.Parse(stack.Pop());

                if (oper == "-")
                {
                    stack.Push((firstNum - secondtNum).ToString());
                }
                else
                {
                    stack.Push((firstNum + secondtNum).ToString());
                };
            }
            Console.WriteLine(stack.Pop());
           
            
        }
    }
}
