using System;

namespace _01.Card_Suit
{
    public class Card : IComparable<Card>
    {
        private CardRanks rank;
        private CardSuits suit;

        public Card(CardRanks rank, CardSuits suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public CardRanks Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public CardSuits Suit
        {
            get { return suit; }
            set { suit = value; }
        }
        private int GetCardPower()
        {
            return (int)this.rank + (int)this.suit;
        }

        public override string ToString()
        {
            return $"{this.rank} of {this.suit}";
        }

        public int CompareTo(Card other)
        {
            return this.GetCardPower().CompareTo(other.GetCardPower());          
        }
    }
}
