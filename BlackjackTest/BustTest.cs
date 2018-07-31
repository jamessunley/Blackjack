using System;
using Blackjack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackjackTest
{
    [TestClass]
    public class BustTest
    {
        [TestMethod]
        public void Given_I_Have_A_Total_of_10_return_false()
        {
            //Given I have a total of 10
            int total = 10;
            //When i call the isBust Method
            IBust bust = new Bust();
            bool totalBust = bust.Calculate(total);
            //Then i get back a false boolean showing the player is not bust
            Assert.IsFalse(totalBust);
        }

        [TestMethod]
        public void Given_I_Have_A_Total_of_20_return_false()
        {
            //Given I have a total of 20
            int total = 20;
            //When i call the isBust Method
            IBust bust = new Bust();
            bool totalBust = bust.Calculate(total);
            //Then i get back a false boolean showing the player is not bust
            Assert.IsFalse(totalBust);
        }

        [TestMethod]
        public void Given_I_Have_A_Total_of_21_return_false()
        {
            //Given I have a total of 21
            int total = 21;
            //When i call the isBust Method
            IBust bust = new Bust();
            bool totalBust = bust.Calculate(total);
            //Then i get back a false boolean showing the player is not bust
            Assert.IsFalse(totalBust);
        }

        [TestMethod]
        public void Given_I_Have_A_Total_of_22_return_true()
        {
            //Given I have a total of 22
            int total = 22;
            //When i call the isBust Method
            IBust bust = new Bust();
            bool totalBust = bust.Calculate(total);
            //Then i get back a false boolean showing the player is not bust
            Assert.IsTrue(totalBust);
        }

        [TestMethod]
        public void Given_I_Have_A_Total_of_25_return_true()
        {
            //Given I have a total of 25
            int total = 25;
            //When i call the isBust Method
            IBust bust = new Bust();
            bool totalBust = bust.Calculate(total);
            //Then i get back a false boolean showing the player is not bust
            Assert.IsTrue(totalBust);
        }

        [TestMethod]
        public void Given_I_Have_A_Total_of_377_return_true()
        {
            //Given I have a total of 377
            int total = 377;
            //When i call the isBust Method
            IBust bust = new Bust();
            bool totalBust = bust.Calculate(total);
            //Then i get back a false boolean showing the player is not bust
            Assert.IsTrue(totalBust);
        }
    }
}
