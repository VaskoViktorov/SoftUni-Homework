using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var number = sum % 10;
            string value = null;
            int tens = sum / 10;
            string vtens = null;

            if (sum < 101 && sum > 0)
            {

                if (sum == 10)
                    value = "ten";
                else if (sum == 11)
                    value = "eleven";
                else if (sum == 12)
                    value = "twelve";
                else if (sum == 13)
                    value = "thirteen";
                else if (sum == 14)
                    value = "fourteen";
                else if (sum == 15)
                    value = "fifteen";
                else if (sum == 16)
                    value = "sixteen";
                else if (number == 17)
                    value = "seventeen";
                else if (sum == 18)
                    value = "eighteen";
                else if (sum == 19)
                    value = "nineteen";
                else if (number == 1)
                    value = "one";
                else if (number == 2)
                    value = "two";
                else if (number == 3)
                    value = "three";
                else if (number == 4)
                    value = "four";
                else if (number == 5)
                    value = "five";
                else if (number == 6)
                    value = "six";
                else if (number == 7)
                    value = "seven";
                else if (number == 8)
                    value = "eight";
                else if (number == 9)
                    value = "nine";

                if (tens == 2)
                    vtens = "twenty";
                else if (tens == 3)
                    vtens = "thirty";
                else if (tens == 4)
                    vtens = "fourty";
                else if (tens == 5)
                    vtens = "fifty";
                else if (tens == 6)
                    vtens = "sixty";
                else if (tens == 7)
                    vtens = "seventy";
                else if (tens == 8)
                    vtens = "eighty";
                else if (tens == 9)
                    vtens = "ninety";
                else if (tens == 10)
                    vtens = "one hundred";

                {

                    if (sum > 0 && sum <= 19)
                        Console.WriteLine(value);
                    else if (sum % 10 == 0)
                        Console.WriteLine(vtens);
                    else
                        Console.WriteLine("{0} {1}", vtens, value);
                }
            }


            else if (sum == 0)

                Console.WriteLine("zero");

            else
                Console.WriteLine("invalid number");

        }
    }
}
