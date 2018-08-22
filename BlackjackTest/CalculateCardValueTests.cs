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
        public void Given_I_Have_a_card_with_the_value_of_King_and_ace_bool_set_to_false_10_will_be_returned()
        {
            //Given I have a card with a value of King 
            var value = "King";
            //And an ace boolean of false
            Boolean ace = false;
            //When I call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            string result = calculateCardValue.Calculate(value, ace);
            //Then I get back a value of 10 
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Queen_and_ace_bool_set_to_false_10_will_be_returned()
        {
            //Given I have a card with a value of Queen 
            var value = "Queen";
            //And an ace boolean of false
            Boolean ace = false;
            //When I call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            string result = calculateCardValue.Calculate(value, ace);
            //Then I get back a value of 10 
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Jack_and_ace_bool_set_to_false_10_will_be_returned()
        {
            //Given I have a card with a value of Jack
            var value = "Jack";
            //And an ace boolean of false
            Boolean ace = false;
            //When I call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            string result = calculateCardValue.Calculate(value, ace);
            //Then I get back a value of 10 
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Ace_and_ace_bool_set_to_false_1_will_be_returned()
        {
            //Given I have a card with a value of Ace
            var value = "Ace";
            //And an ace boolean of false
            Boolean ace = false;
            //When I call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            string result = calculateCardValue.Calculate(value, ace);
            //Then I get back a value of 11 
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_Ace_and_ace_bool_set_to_true_11_will_be_returned()
        {
            //Given I have a card with a value of Ace
            var value = "Ace";
            //And an ace boolean of true
            Boolean ace = true;
            //When I call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            string result = calculateCardValue.Calculate(value, ace);
            //Then I get back a value of 11 
            Assert.AreEqual("11", result);
        }

        [TestMethod]
        public void Given_I_Have_a_card_with_the_value_of_King_and_ace_bool_set_to_true_10_will_be_returned()
        {
            //Given I have a card with a value of King
            var value = "King";
            //And an ace boolean of true
            Boolean ace = true;
            //When I call the calculate card value method
            ICalculateCardValue calculateCardValue = new CalculateCardValue();
            string result = calculateCardValue.Calculate(value, ace);
            //Then I get back a value of 10 
            Assert.AreEqual("10", result);
        }
    }
}
