using System;
using System.Collections.Generic;
using Blackjack;
using Blackjack.Deck;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BlackjackTest
{
    [TestClass]
    public class TotalFlowTest
    {
        [TestMethod]
        public void Given_I_Have_2_Cards_calculateCardValue_is_called_twice()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and 6
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //And I have a calculateTotal object
            Mock<ICalculateCardValue> mock = new Mock<ICalculateCardValue>();
            //When i call the calculate score Flow method
            ICalculateTotal calculateTotalFlow = new CalculateTotal(mock.Object);
            calculateTotalFlow.Calculate(dealer, aceBool);
            //Then i will verify that the Calculate card value object is called twice
            mock.Verify(m => m.Calculate(It.IsAny<string>(), It.IsAny<Boolean>()), Times.Exactly(2));
        }

        [TestMethod]
        public void Given_I_Have_3_Cards_calculateCardValue_is_called_three_times()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3, 6 and 9
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //And I have a calculateTotal object
            Mock<ICalculateCardValue> mock = new Mock<ICalculateCardValue>();
            //When i call the calculate score Flow method
            ICalculateTotal calculateTotalFlow = new CalculateTotal(mock.Object);
            calculateTotalFlow.Calculate(dealer, aceBool);
            //Then i will verify that the Calculate card value object is called twice
            mock.Verify(m => m.Calculate(It.IsAny<string>(), It.IsAny<Boolean>()), Times.Exactly(3));
        }

        [TestMethod]
        public void Given_I_Have_4_Cards_calculateCardValue_is_called_four_times()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3, 6, 9 and King
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "King" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //And I have a calculateTotal object
            Mock<ICalculateCardValue> mock = new Mock<ICalculateCardValue>();
            //When i call the calculate score Flow method
            ICalculateTotal calculateTotalFlow = new CalculateTotal(mock.Object);
            calculateTotalFlow.Calculate(dealer, aceBool);
            //Then i will verify that the Calculate card value object is called twice
            mock.Verify(m => m.Calculate(It.IsAny<string>(), It.IsAny<Boolean>()), Times.Exactly(4));
        }

        [TestMethod]
        public void Given_I_Have_5_Cards_calculateCardValue_is_called_five_times()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3, 6, 9, King and Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "King" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //And I have a calculateTotal object
            Mock<ICalculateCardValue> mock = new Mock<ICalculateCardValue>();
            //When i call the calculate score Flow method
            ICalculateTotal calculateTotalFlow = new CalculateTotal(mock.Object);
            calculateTotalFlow.Calculate(dealer, aceBool);
            //Then i will verify that the Calculate card value object is called twice
            mock.Verify(m => m.Calculate(It.IsAny<string>(), It.IsAny<Boolean>()), Times.Exactly(5));
        }
    }
}
