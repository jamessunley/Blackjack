using System.Collections.Generic;
using Blackjack.Deck;

namespace BlackjackTest
{
    public interface ICalculateCardValue
    {
        int Calculate(List<Card> dealer, bool aceBool);
    }
}