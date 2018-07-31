using System;
using Blackjack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackjackTest
{
    [TestClass]
    public class CalculateWinTest
    {
        [TestMethod]
        public void Given_I_Have_a_playerTotal_10_and_a_dealerTotal_18_return_dealer()
        {
            //Given I have a total of 10
            int playerTotal = 10;
            //And I have a dealer list with a total of 18
            int dealerTotal = 18;
            //When i call the winner Method
            IWinner win = new Winner();
            string final = win.Calculate(playerTotal, dealerTotal);
            //Then i get back a string stating "Dealer has won"
            Assert.AreEqual("dealer", final);
        }

        [TestMethod]
        public void Given_I_Have_a_playerTotal_18_and_a_dealerTotal_10_return_player()
        {
            //Given I have a total of 18
            int playerTotal = 18;
            //And I have a dealer list with a total of 10
            int dealerTotal = 10;
            //When i call the winner Method
            IWinner win = new Winner();
            string final = win.Calculate(playerTotal, dealerTotal);
            //Then i get back a string stating "Player has won"
            Assert.AreEqual("player", final);
        }

        [TestMethod]
        public void Given_I_Have_a_playerTotal_21_and_a_dealerTotal_18_return_player()
        {
            //Given I have a total of 21
            int playerTotal = 21;
            //And I have a dealer list with a total of 18
            int dealerTotal = 18;
            //When i call the winner Method
            IWinner win = new Winner();
            string final = win.Calculate(playerTotal, dealerTotal);
            //Then i get back a string stating "Player has won"
            Assert.AreEqual("player", final);
        }

        [TestMethod]
        public void Given_I_Have_a_playerTotal_18_and_a_dealerTotal_21_return_dealer()
        {
            //Given I have a total of 18
            int playerTotal = 18;
            //And I have a dealer list with a total of 21
            int dealerTotal = 21;
            //When i call the winner Method
            IWinner win = new Winner();
            string final = win.Calculate(playerTotal, dealerTotal);
            //Then i get back a string stating "dealer has won"
            Assert.AreEqual("dealer", final);
        }

        [TestMethod]
        public void Given_I_Have_a_playerTotal_18_and_a_dealerTotal_22_return_player()
        {
            //Given I have a total of 18
            int playerTotal = 18;
            //And I have a dealer list with a total of 22
            int dealerTotal = 22;
            //When i call the winner Method
            IWinner win = new Winner();
            string final = win.Calculate(playerTotal, dealerTotal);
            //Then i get back a string stating "Player has won"
            Assert.AreEqual("player", final);
        }

        [TestMethod]
        public void Given_I_Have_a_playerTotal_22_and_a_dealerTotal_18_return_dealer()
        {
            //Given I have a total of 22
            int playerTotal = 22;
            //And I have a dealer list with a total of 18
            int dealerTotal = 18;
            //When i call the winner Method
            IWinner win = new Winner();
            string final = win.Calculate(playerTotal, dealerTotal);
            //Then i get back a string stating "dealer has won"
            Assert.AreEqual("dealer", final);
        }

        [TestMethod]
        public void Given_I_Have_a_playerTotal_12_and_a_dealerTotal_12_return_draw()
        {
            //Given I have a total of 12
            int playerTotal = 12;
            //And I have a dealer list with a total of 12
            int dealerTotal = 12;
            //When i call the winner Method
            IWinner win = new Winner();
            string final = win.Calculate(playerTotal, dealerTotal);
            //Then i get back a string stating "a draw has occured
            Assert.AreEqual("draw", final);
        }

    }
}
