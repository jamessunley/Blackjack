using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackjack;
using Blackjack.Deck;

namespace BlackjackTest
{
    [TestClass]
    public class ReturnCardTest
    {
        [TestMethod]
        public void Given_I_have_a_deck_where_the_last_card_is_a_King_return_King_of_Clubs()
        {
            //Given I have a deck list
            List<Card> deck = new List<Card>();
            //And the deck contains 2, 3, 6, 9, King
            deck.Add( new Card { Suit = Suit.Clubs , Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "King" });
            //when i call the returnCard method
            IReturnCard returnCard = new ReturnCard();
            Card final = returnCard.ReturnCardFromDeck(deck);
            //Then I will get back an string (card) from top of deck
            Assert.AreEqual("King", final.Value);
            Assert.AreEqual("Clubs", final.Suit.ToString());
        }

        [TestMethod]
        public void Given_I_have_a_deck_where_the_last_card_is_a_9_return_9_of_Clubs()
        {
            //Given I have a deck list
            List<Card> deck = new List<Card>();
            //And the deck contains 2, 3, 6, 9
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "9" });
            //when i call the returnCard method
            IReturnCard returnCard = new ReturnCard();
            Card final = returnCard.ReturnCardFromDeck(deck);
            //Then I will get back an string (card) from top of deck
            Assert.AreEqual("9", final.Value);
            Assert.AreEqual("Clubs", final.Suit.ToString());
        }

        [TestMethod]
        public void Given_I_have_a_deck_where_the_last_card_is_a_4_return_4_of_Hearts()
        {
            //Given I have a deck list
            List<Card> deck = new List<Card>();
            //And the deck contains 2, 3, 6, 4
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            deck.Add(new Card { Suit = Suit.Hearts, Value = "4" });
            //when i call the returnCard method
            IReturnCard returnCard = new ReturnCard();
            Card final = returnCard.ReturnCardFromDeck(deck);
            //Then I will get back an string (card) from top of deck
            Assert.AreEqual("4", final.Value);
            Assert.AreEqual("Hearts", final.Suit.ToString());
        }

        [TestMethod]
        public void Given_I_have_a_deck_where_the_last_card_is_a_Queen_return_Queen_of_Diamonds()
        {
            //Given I have a deck list
            List<Card> deck = new List<Card>();
            //And the deck contains 2, 3, 6, King, Queen
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            deck.Add(new Card { Suit = Suit.Hearts, Value = "King" });
            deck.Add(new Card { Suit = Suit.Diamonds, Value = "Queen" });
            //when i call the returnCard method
            IReturnCard returnCard = new ReturnCard();
            Card final = returnCard.ReturnCardFromDeck(deck);
            //Then I will get back an string (card) from top of deck
            Assert.AreEqual("Queen", final.Value);
            Assert.AreEqual("Diamonds", final.Suit.ToString());
        }

        [TestMethod]
        public void Given_I_have_a_deck_where_the_last_card_is_a_Queen_return_Queen_of_Spades()
        {
            //Given I have a deck list
            List<Card> deck = new List<Card>();
            //And the deck contains 2, 3, 6, King, Queen
            deck.Add(new Card { Suit = Suit.Clubs, Value = "2" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "3" });
            deck.Add(new Card { Suit = Suit.Clubs, Value = "6" });
            deck.Add(new Card { Suit = Suit.Hearts, Value = "King" });
            deck.Add(new Card { Suit = Suit.Spades, Value = "Queen" });
            //when i call the returnCard method
            IReturnCard returnCard = new ReturnCard();
            Card final = returnCard.ReturnCardFromDeck(deck);
            //Then I will get back an string (card) from top of deck
            Assert.AreEqual("Queen", final.Value);
            Assert.AreEqual("Spades", final.Suit.ToString());
        }

    }
}

