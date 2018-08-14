using Blackjack.Deck;
using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class CalculateTotal : ICalculateTotal
    {
        public int Calculate(List<Card> dealer)
        {
            int total = 0;

            dealer.ForEach(card =>
           {
               if (card.Value == "Jack" || card.Value == "Queen" || card.Value == "King")
               {
                   total += 10;
               }else if (card.Value == "Ace")
               {
                   total += 11;
               }
               else
                   total += Int32.Parse(card.Value);
           });

            return total;
        }
    }
}