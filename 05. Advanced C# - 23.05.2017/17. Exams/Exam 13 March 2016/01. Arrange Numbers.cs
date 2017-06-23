using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(new[] {' ', ',', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            List<Nums> nums = new List<Nums>();
            for (int i = 0; i < input.Length; i++)
            {
                var currentNum = string.Empty;
                Nums current = new Nums();
                for (int j = 0; j < input[i].ToString().Length; j++)
                {
                   
                    switch (input[i].ToString()[j])
                    {
                        case '1':
                            currentNum += "one";
                            break;
                        case '2':
                            currentNum += "two";
                            break;
                        case '3':
                            currentNum += "three";
                            break;
                        case '4':
                            currentNum += "four";
                            break;
                        case '5':
                            currentNum += "five";
                            break;
                        case '6':
                            currentNum += "six";
                            break;
                        case '7':
                            currentNum += "seven";
                            break;
                        case '8':
                            currentNum += "eight";
                            break;
                        case '9':
                            currentNum += "nine";
                            break;
                        case '0':
                            currentNum += "zero";
                            break;
                    }
                    
                    if (input[i].ToString().Length > j)
                    {
                        currentNum += "-";
                    }
                }
                current.Number = input[i];
                current.WritenNumber = currentNum;
                nums.Add(current);
            }

            var newList = nums.OrderBy(x => x.WritenNumber).Select(x => x.Number).ToList();
            Console.Write(string.Join(", " , newList));
        }

      public class Nums
        {
           public  int Number {get; set;}
            public  string WritenNumber { get; set; }
        }
    }
}
