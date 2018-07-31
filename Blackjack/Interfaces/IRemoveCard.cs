using Blackjack.Deck;
using System.Collections.Generic;

namespace Blackjack
{
    public interface IRemoveCard
    {
        List<Card> RemoveCardFromDeck(List <Card>deck);
    }
}