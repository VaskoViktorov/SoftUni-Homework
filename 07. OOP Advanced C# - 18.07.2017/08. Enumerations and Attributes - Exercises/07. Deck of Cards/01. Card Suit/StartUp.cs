using System;

namespace _01.Card_Suit
{
    public class StartUp
    {
        public static void Main()
        {
            var ranks = typeof(CardRanks).GetEnumValues();
            var suits = typeof(CardSuits).GetEnumValues();

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}
