namespace _01.Card_Suit
{
    public class Card
    {
        private CardRanks rank;
        private CardSuits suit;

        public Card(CardRanks rank, CardSuits suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        private int GetCardPower()
        {
            return (int)this.rank + (int)this.suit;
        }

        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {this.GetCardPower()}";
        }
    }
}
