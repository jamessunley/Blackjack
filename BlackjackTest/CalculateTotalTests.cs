using System;
using System.Collections.Generic;
using Blackjack;
using Blackjack.Deck;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BlackjackTest
{
    [TestClass]
    public class CalculateTotalTests
    {
        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_a_6_return_a_total_of_9()
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
            ICalculateTotal calculateTotalFlow = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotalFlow.Calculate(dealer, aceBool);
            ////Then i get back a total of 9
            Assert.AreEqual(9, total);
            //Then i will verify that the Calculate card value object is called twice
            //mock.Verify(m => m.Calculate(It.IsAny<List<Card>>(), aceBool), Times.Once);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_9_and_a_10_return_a_total_of_19()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 9 and 10
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 19
            Assert.AreEqual(19, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_a_6_and_a_9_return_a_total_of_18()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and 6 and 9
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 18
            Assert.AreEqual(18, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_a_6_and_a_9_and_a_2_return_a_total_of_20()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and 6 and 9 and 2
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_10_and_a_9_and_a_8_return_a_total_of_27()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 10 and 9 and 8
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "8" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 27
            Assert.AreEqual(27, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_10_and_a_10_return_a_total_of_20()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 10 and 10
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_10_and_a_Jack_return_a_total_of_20()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 10 and Jack
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Jack" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_10_and_a_Queen_return_a_total_of_20()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 10 and Queen
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Queen" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_10_and_a_king_return_a_total_of_20()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 10 and King
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "King" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_10_and_a_Ace_and_option_of_ace_being_true_return_a_total_of_21()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 10 and Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //And the ace == 1 (false)
            Boolean aceBool = true;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 21
            Assert.AreEqual(21, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_Jack_and_a_Queen_return_a_total_of_20()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are Jack and Queen
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Queen" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Jack" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_an_Ace_and_a_Queen_with_the_option_of_ace_being_false_return_a_total_of_11()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are Jack and Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Jack" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 11
            Assert.AreEqual(11, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_a_6_and_a_8_return_a_total_of_17()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and 6 and 8
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "8" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 17
            Assert.AreEqual(17, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_a_6_and_a_8_and_a_2_return_a_total_of_19()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and 6 and 8 and a 2
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "8" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 19
            Assert.AreEqual(19, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_a_6_and_a_8_and_a_2_and_another_2_return_a_total_of_21()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and 6 and 8 and a 2 and another 2
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "8" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 21
            Assert.AreEqual(21, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_a_6_and_a_8_and_a_2_and_an_Ace_with_the_ace_being_false_return_a_total_of_20()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and 6 and 8 and a 2 and an Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "8" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_an_Ace_with_the_ace_being_false_return_a_total_of_4()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and an Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //And the ace == 1 (false)
            Boolean aceBool = false;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 4
            Assert.AreEqual(4, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_3_and_an_Ace_with_the_ace_being_true_return_a_total_of_14()
        {
            //Given I have a list of 3 cards
            List<Card> dealer = new List<Card>();
            //And they are 3 and an Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //And the ace == 1 (false)
            Boolean aceBool = true;
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal(new CalculateCardValue());
            int total = calculateTotal.Calculate(dealer, aceBool);
            //Then i get back a total of 14
            Assert.AreEqual(14, total);
        }
    }
}
