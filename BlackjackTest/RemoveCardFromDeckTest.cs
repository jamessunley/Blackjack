using System;
using System.Collections.Generic;
using Blackjack;
using Blackjack.Deck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackjackTest
{
    [TestClass]
    public class RemoveCardFromDeckTest
    {
        [TestMethod]
        public void Given_deck_of_5_return_deck_of_4()
        {
            //Given I have a deck list with a length of 5
            List<Card> deck = new List<Card>();
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //When I call the removeCardFromDeck method
            IRemoveCard remove = new RemoveCard();
            List<Card> final = remove.RemoveCardFromDeck(deck);
            //Then I will get back a deck list with a length of 4
            Assert.AreEqual(4, final.Count);
        }

        [TestMethod]
        public void Given_deck_of_4_return_deck_of_3()
        {
            //Given I have a deck list with a length of 4
            List<Card> deck = new List<Card>();
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //When I call the removeCardFromDeck method
            IRemoveCard remove = new RemoveCard();
            List<Card> final = remove.RemoveCardFromDeck(deck);
            //Then I will get back a deck list with a length of 3
            Assert.AreEqual(3, final.Count);
        }

        [TestMethod]
        public void Given_deck_of_3_return_deck_of_2()
        {
            //Given I have a deck list with a length of 3
            List<Card> deck = new List<Card>();
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //When I call the removeCardFromDeck method
            IRemoveCard remove = new RemoveCard();
            List<Card> final = remove.RemoveCardFromDeck(deck);
            //Then I will get back a deck list with a length of 2
            Assert.AreEqual(2, final.Count);
        }

        [TestMethod]
        public void Given_deck_of_2_return_deck_of_1()
        {
            //Given I have a deck list with a length of 2
            List<Card> deck = new List<Card>();
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //When I call the removeCardFromDeck method
            IRemoveCard remove = new RemoveCard();
            List<Card> final = remove.RemoveCardFromDeck(deck);
            //Then I will get back a deck list with a length of 1
            Assert.AreEqual(1, final.Count);
        }

        [TestMethod]
        public void Given_deck_of_1_return_deck_of_0()
        {
            //Given I have a deck list with a length of 1
            List<Card> deck = new List<Card>();
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            //When I call the removeCardFromDeck method
            IRemoveCard remove = new RemoveCard();
            List<Card> final = remove.RemoveCardFromDeck(deck);
            //Then I will get back a deck list with a length of 0
            Assert.AreEqual(0, final.Count);
        }

        [TestMethod]
        public void Given_deck_of_0_return_deck_of_0()
        {
            //Given I have a deck list with a length of 0
            List<Card> deck = new List<Card>();
            //When I call the removeCardFromDeck method
            IRemoveCard remove = new RemoveCard();
            List<Card> final = remove.RemoveCardFromDeck(deck);
            //Then I will get back a deck list with a length of 0
            Assert.AreEqual(0, final.Count);
        }
    }
}
