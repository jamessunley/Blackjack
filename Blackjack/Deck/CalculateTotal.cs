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
               if (card.Value.StartsWith("J") || card.Value.StartsWith("Q") || card.Value.StartsWith("K"))
               {
                   total += 10;
               }else if (card.Value.StartsWith("A"))
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