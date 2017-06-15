using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication206
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            LastDigit(Math.Abs(num));

            Console.WriteLine(NumToText(LastDigit(Math.Abs(num)).ToString()));

        }

        static long LastDigit(long num)
        {
            long number = 11;
            while (number > 10)
            {
                number = num % 10;
            }
            return number;
        }

        static string NumToText(string num)
        {
            var number = " ";
            switch (num)

            {
                case "0": number = "zero"; return number;
                case "1": number = "one"; return number;
                case "2": number = "two"; return number;
                case "3": number = "three"; return number;
                case "4": number = "four"; return number;
                case "5": number = "five"; return number;
                case "6": number = "six"; return number;
                case "7": number = "seven"; return number;
                case "8": number = "eight"; return number;
                case "9": number = "nine"; return number;

            }
            return num;

        }
    }
}
