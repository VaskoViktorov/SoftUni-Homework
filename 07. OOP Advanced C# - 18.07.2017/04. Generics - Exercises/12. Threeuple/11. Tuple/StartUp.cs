using System;
using System.Collections.Generic;

namespace _11.Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Threeuple<string, string,string> firstThreeuple = new Threeuple<string, string, string>(input[0]+" " + input[1], input[2], input[3]);
            Console.WriteLine(firstThreeuple.ToString());

            input = Console.ReadLine().Split();
            bool isDrunk = input[2] == "drunk";
            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>(input[0] , int.Parse(input[1]), isDrunk);
            Console.WriteLine(secondThreeuple.ToString());

            input = Console.ReadLine().Split();
            Threeuple<string,double,string> thirdThreeuple = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);
            Console.WriteLine(thirdThreeuple.ToString());

        }
    }
}
