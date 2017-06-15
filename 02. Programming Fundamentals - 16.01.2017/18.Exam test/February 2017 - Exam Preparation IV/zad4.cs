using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication357
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();
            string pattern = @"^(\d+)([a-zA-Z]+)([\d\W]*)$";
            Regex reg = new Regex(pattern);
            int[] numbers = new int[10] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            List<string> list = new List<string>();
            string text = string.Empty;
            string code = string.Empty;

            while (msg != "Over!")
            {
                int num = int.Parse(Console.ReadLine());
                Match a = reg.Match(msg);

                if (!a.Success)
                {
                    msg = Console.ReadLine();
                    continue;
                }

                if (a.Groups[2].Length != num)
                {
                    msg = Console.ReadLine();
                    continue;
                }
                text = a.Groups[2].ToString();

                foreach (char item in a.Groups[1].ToString())
                {
                    if (numbers.Contains(item) && text.Length > int.Parse(item.ToString()))
                    {
                        code += text[int.Parse(item.ToString())];
                    }
                    else if (numbers.Contains(item))
                    {
                        code += " ";
                    }
                }

                foreach (char item in a.Groups[3].ToString())
                {
                    if (numbers.Contains(item) && text.Length > int.Parse(item.ToString()))
                    {
                        code += text[int.Parse(item.ToString())];
                    }
                    else if (numbers.Contains(item))
                    {
                        code += " ";
                    }
                }

                list.Add($"{text} == {code}");
                msg = Console.ReadLine();
                code = string.Empty;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.TrimEnd());
            }
        }
    }
}
