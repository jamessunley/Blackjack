using Blackjack.Deck;
using BlackjackTest;
using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class CalculateTotal : ICalculateTotal
    {
        private readonly ICalculateCardValue cardValue;

        public CalculateTotal(ICalculateCardValue cardValue)
        {
            this.cardValue = cardValue;
        }

        public int Calculate(List<Card> dealer, Boolean aceBool)
        {
            int total = 0;

            dealer.ForEach(card =>
            {
                 total += Convert.ToInt32(cardValue.Calculate(card.Value, aceBool));
            });

            return total;
        }
    }
}