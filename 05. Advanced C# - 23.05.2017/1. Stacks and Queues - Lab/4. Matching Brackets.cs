using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> holder = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    holder.Push(i);
                }

                if(input[i] == ')')
                {
                    int num = holder.Pop();
                    string expresions = input.Substring(num, i-num+1);
                    Console.WriteLine(expresions);
                }
            }
           
        }
    }
}
