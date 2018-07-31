using Blackjack.Deck;
using System.Collections.Generic;

namespace Blackjack
{
    public interface ICalculateTotal
    {
        int Calculate(List<Card> dealer);
    }
}