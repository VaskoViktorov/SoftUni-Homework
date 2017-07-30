using System;

namespace _01.Card_Suit
{
    public class StartUp
    {
        public static void Main()
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();
            Card card = new Card((CardRanks)Enum.Parse(typeof(CardRanks), rank), (CardSuits)Enum.Parse(typeof(CardSuits), suit));
            Console.WriteLine(card.ToString());
        }
    }
}
