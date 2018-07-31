using Blackjack.Deck;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    public class ReturnCard : IReturnCard
    {
        public Card ReturnCardFromDeck(List<Card> deck)
        {
            return deck.LastOrDefault();
        }
    }
}