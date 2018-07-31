using System;
using System.Collections.Generic;
using Blackjack;
using Blackjack.Deck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
            //Then i get back a total of 9
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_9_and_a_10_return_a_total_of_19()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 9 and 10
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }

        [TestMethod]
        public void Given_I_Have_a_card_list_containing_a_10_and_a_Ace_return_a_total_of_20()
        {
            //Given I have a list of 2 cards
            List<Card> dealer = new List<Card>();
            //And they are 10 and Ace
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "10" });
            dealer.Add(new Card { Suit = Suit.Clubs, Value = "Ace" });
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
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
            //When i call the calculate score method
            ICalculateTotal calculateTotal = new CalculateTotal();
            int total = calculateTotal.Calculate(dealer);
            //Then i get back a total of 20
            Assert.AreEqual(20, total);
        }
    }
}
