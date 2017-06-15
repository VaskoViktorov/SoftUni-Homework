using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication259
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();            
            char num = ' ';
            string newNum = "";
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = list[i].Length-1; j >= 0; j--)
                {
                    num = list[i][j];
                    newNum += num;
                    
                }
                sum += int.Parse(newNum);
                newNum = "";
                
            }
            Console.WriteLine(sum);

        }
    }
}
