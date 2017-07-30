using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Card_Suit
{
    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Card> cards = new SortedSet<Card>();

            CardRanks rankFirstCard = (CardRanks)Enum.Parse(typeof(CardRanks), Console.ReadLine());
            CardSuits suitFirstCard = (CardSuits)Enum.Parse(typeof(CardSuits), Console.ReadLine());
            var firstCard = new Card(rankFirstCard, suitFirstCard);
            cards.Add(firstCard);

            CardRanks rankSecondCard = (CardRanks)Enum.Parse(typeof(CardRanks), Console.ReadLine());
            CardSuits suitSecondCard = (CardSuits)Enum.Parse(typeof(CardSuits), Console.ReadLine());
            var secondCard = new Card(rankSecondCard, suitSecondCard);
            cards.Add(secondCard);

            Console.WriteLine(cards.Last());
        }
    }
}
