using Blackjack.Deck;
using Blackjack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        private static IStartDeck startDeck = new InitialseDeck();
        private static IReturnCard returnCard = new ReturnCard();
        private static IRemoveCard removeCard = new RemoveCard();
        private static ICalculateTotal calculateTotal = new CalculateTotal();
        private static IWinner winner = new Winner();
        private static IBust bust = new Bust();

        public static List<Card> playerHand = new List<Card>();
        public static List<Card> dealerHand = new List<Card>();
        static void Main(string[] args)
        {
            List<Card> deck = startDeck.InitialisedDeck();

            for(int i = 0; i<52; i++)
            {
                Console.WriteLine(deck[i].Value + " of " + deck[i].Suit);
            }

            Console.WriteLine ("Welcome! To play Blackjack press Y. To quit press N.");
            string decision = Console.ReadLine();

            int total = 0;
            int dealerTotal = 0;
            if (decision == "y" || decision == "Y")
            {
                Card playerCard1 = (returnCard.ReturnCardFromDeck(deck));
                deck = (removeCard.RemoveCardFromDeck(deck));
                Card playerCard2 = (returnCard.ReturnCardFromDeck(deck));
                deck = (removeCard.RemoveCardFromDeck(deck));
                Card dealerCard1 = (returnCard.ReturnCardFromDeck(deck));
                deck = (removeCard.RemoveCardFromDeck(deck));
                Card dealerCard2 = (returnCard.ReturnCardFromDeck(deck));
                deck = (removeCard.RemoveCardFromDeck(deck));

                playerHand.Add(playerCard1);
                playerHand.Add(playerCard2);

                dealerHand.Add(dealerCard1);
                dealerHand.Add(dealerCard2);

                Console.WriteLine(playerHand[0].Value + " of " + deck[0].Suit);
                Console.WriteLine(playerHand[1].Value + " of " + deck[1].Suit);
                total = calculateTotal.Calculate(playerHand);
                Console.WriteLine("Your current hand is equal to: " + total);

                Console.WriteLine("Do you want to stick or twist? T/S");
                decision = Console.ReadLine();

                while(decision == "T" || decision == "t")
                {
                    Console.WriteLine("Twist");

                        
                    Card playerCard = (returnCard.ReturnCardFromDeck(deck));
                    deck = (removeCard.RemoveCardFromDeck(deck));
                    playerHand.Add(playerCard);

                    int i = 0;
                    foreach(Card card in playerHand)
                    {
                        Console.WriteLine(playerHand[i].Value + " of " + deck[i].Suit);
                        i++;
                    }
                    total = calculateTotal.Calculate(playerHand);
                    Console.WriteLine("Your current hand is equal to: " + total);

                    if (bust.Calculate(total))
                    {
                        decision = "S";
                        Console.WriteLine("You are bust!");
                    }
                    else
                    {
                        Console.WriteLine("Do you want to stick or twist? T/S");
                        decision = Console.ReadLine();
                    }
                }
            }

            if(decision == "S"|| decision == "s")
            {
                dealerTotal = calculateTotal.Calculate(dealerHand);
                bool isBust = bust.Calculate(dealerTotal);
                while (!isBust)
                {
                    Console.WriteLine("The dealer's current hand is equal to: " + dealerTotal);
                    int i = 0;
                    Card dealerCard = (returnCard.ReturnCardFromDeck(deck));
                    deck = (removeCard.RemoveCardFromDeck(deck));
                    dealerHand.Add(dealerCard);
                    foreach (Card card in dealerHand)
                    {
                        Console.WriteLine(dealerHand[i].Value + " of " + deck[i].Suit);
                        i++;
                    }
                    dealerTotal = calculateTotal.Calculate(dealerHand);
                    isBust = bust.Calculate(dealerTotal);
                    if (dealerTotal >= 17)
                    {
                        isBust = true;
                    }
                }
                Console.WriteLine("Dealer went bust! They had a hand equaling: " + dealerTotal);
                if(total == dealerTotal)
                {
                    Console.WriteLine("The game is a: " + winner.Calculate(total, dealerTotal));
                }
                Console.WriteLine("The Winner is the " + winner.Calculate(total, dealerTotal));
            }
            else if (decision == "n" || decision == "N")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Press Enter to Quit");
            Console.ReadKey();
        }
    }
}
