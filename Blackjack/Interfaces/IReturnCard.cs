using Blackjack.Deck;
using System.Collections.Generic;

namespace Blackjack
{
    public interface IReturnCard
    {
        Card ReturnCardFromDeck(List<Card> deck);
    }
}