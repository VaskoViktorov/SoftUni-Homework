using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication305
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new string[] {" ", "\n", "\t", "\r"}, StringSplitOptions.RemoveEmptyEntries).ToArray();          
            string num = "";
            char left = new char();
            char right = new char();
            decimal result = 0;
            decimal final = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 1; j <= text[i].Length-2; j++)
                {                   
                    num += text[i][j];  
                    
                }
                left += text[i][0];
                right += text[i][text[i].Length - 1];
                
               
                    if ((int)left < 96)
                    {
                        result += decimal.Parse(num) / ((int)left - 64);

                    }
                    else
                    {
                        result += decimal.Parse(num) * ((int)left - 96);
                    }
                    if ((int)right < 96)
                    {
                        result -= ((int)right - 64);
                    }
                    else
                    {
                        result += ((int)right - 96);
                    }
                    final += result;
                    result = 0;
                    num = "";
                    left = new char();
                    right = new char();
                
               
            }
          
            Console.WriteLine($"{final:f2}");
        }
    }
}
