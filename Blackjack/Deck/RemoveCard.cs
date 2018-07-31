using System.Collections.Generic;
using Blackjack;
using Blackjack.Deck;

namespace Blackjack
{
    public class RemoveCard : IRemoveCard
    {
        public List<Card> RemoveCardFromDeck(List<Card> deck)
        {
            if(deck.Count == 0)
            {
                return deck;
            }
            deck.RemoveAt(deck.Count - 1);
            return deck;

        }
    }
}