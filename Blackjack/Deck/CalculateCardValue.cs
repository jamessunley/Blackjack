using System;
using System.Collections.Generic;
using Blackjack.Deck;

namespace BlackjackTest
{
    public class CalculateCardValue : ICalculateCardValue
    {
        public string Calculate(string value, bool aceBool)
        {
            if (value == "Jack" || value == "Queen" || value == "King")
            {
                return "10";
            }
            if (value == "Ace" && aceBool)
            {
                return "11";
            }
            if (value == "Ace" && !aceBool)
            {
                return "1";
            }

            return value;
        }
    }
}
