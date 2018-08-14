using System;
using System.Collections.Generic;
using Blackjack.Deck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackjackTest
{
    [TestClass]
    public class CalculateCardValueTests
    {
        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_3_3_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are 3 
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 3
            Assert.AreEqual(3, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_6_6_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are 6
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 6
            Assert.AreEqual(6, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_9_9_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are 9
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 9
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_King_10_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are King
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "King" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 10
            Assert.AreEqual(10, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Jack_10_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are Jack
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Jack" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 10
            Assert.AreEqual(10, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Queen_10_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are Queen
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Queen" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 10
            Assert.AreEqual(10, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Ace_and_ace_value_is_true_11_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //And the ace == 11 (true)
            Boolean aceBool = true;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 11
            Assert.AreEqual(11, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Ace_and_ace_value_is_false_1_will_be_returned()
        {
            //Given I have a list of 1 cardd
            List<Card> dealer = new List<Card>();
            //And they are Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            int total = calculateCardValue.Calculate(dealer, aceBool);
            //Then i get back a total of 1
            Assert.AreEqual(1, total);
        }
    }
}
