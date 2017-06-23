using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            
            while (input != "Over!")
            {
                int num = int.Parse(Console.ReadLine());
                Regex reg = new Regex($"^([0-9]+)([a-zA-Z]{{{num}}})(\\d*)([^a-zA-Z]*)$");

                if (reg.IsMatch(input))
                {
                    Match text = reg.Match(input);
                    string nums = text.Groups[1].ToString();
                    string msg = text.Groups[2].ToString();

                    if (text.Groups[3].Length != 0)
                    {
                        nums += text.Groups[3].ToString();
                    }

                    StringBuilder n = new StringBuilder();

                    foreach (var digit in nums)
                    {
                        var dig = int.Parse(digit.ToString());
                        if(msg.Length >dig)
                        n.Append(msg.Substring(dig,1));
                        else
                        {
                            n.Append(" ");
                        }
                    }
                   
                    Console.WriteLine($"{msg} == {n}");                        
                }
                input = Console.ReadLine();
            }
        }
    }
}
