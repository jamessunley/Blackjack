namespace Blackjack.Deck
{
    public class Card
    {
        public string Value { get; set; } = "0";
        public Suit Suit { get; set; } = Suit.Clubs;

        public Card(Suit suit, string value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public Card()
        {

        }
    }
}