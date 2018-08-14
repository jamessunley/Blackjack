using System;
using System.Collections.Generic;
using Blackjack.Deck;

namespace BlackjackTest
{
    public class CalculateCardValue : ICalculateCardValue
    {
        public int Calculate(List<Card> dealer, bool aceBool)
        {
            int total = 0;

            dealer.ForEach(card =>
            {
                if (card.Value == "Jack" || card.Value == "Queen" || card.Value == "King")
                {
                    total = 10;
                }
                else if (card.Value == "Ace" && aceBool)
                {
                    total = 11;
                }
                else if (card.Value == "Ace" && !aceBool)
                {
                    total = 1;
                }
                else
                    total = Int32.Parse(card.Value);
            });

            return total;
        }
    }
}