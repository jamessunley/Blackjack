using System.Collections.Generic;
using Blackjack.Deck;

namespace BlackjackTest
{
    public interface ICalculateCardValue
    {
        string Calculate(string value, bool aceBool);
    }
}