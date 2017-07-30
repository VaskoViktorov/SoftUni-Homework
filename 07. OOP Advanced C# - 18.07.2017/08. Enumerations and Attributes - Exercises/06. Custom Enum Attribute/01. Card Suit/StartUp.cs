using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Card_Suit
{
    public class StartUp
    {
        public static void Main()
        {
            var enumType = Console.ReadLine();

            Type type = null;

            if (enumType == "Rank")
            {
                type = typeof(CardRanks);
            }
            else
            {
                type = typeof(CardSuits);
            }

            var attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
            }
        }
    }
}
