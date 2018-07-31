using Blackjack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Deck
{
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public class InitialseDeck : IStartDeck
    {

        public List<Card> InitialisedDeck()
        {
            List<Card> Cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 2; i < 11; i++)
                {
                    Cards.Add(new Card(suit, i.ToString()));
                }
                Cards.Add(new Card(suit, "Ace"));
                Cards.Add(new Card(suit, "Jack"));
                Cards.Add(new Card(suit, "Queen"));
                Cards.Add(new Card(suit, "King"));
            }
            return Shuffle(Cards);
        }

        private List<Card> Shuffle(List<Card> cards)
        {
            List<Card> Shuffled = new List<Card>();
            Random random = new Random();
            while (cards.Count > 0)
            {
                int i = random.Next(0, cards.Count);
                Shuffled.Add(cards[i]);
                cards.RemoveAt(i);
            }
            return Shuffled;
        }
    }
}
