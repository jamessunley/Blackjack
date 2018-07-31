namespace Blackjack
{
    public class Winner : IWinner
    {
        public string Calculate(int playerTotal, int dealerTotal)
        {
            if (playerTotal> 21)
            {
                return "dealer";
            }
            if(playerTotal > dealerTotal || dealerTotal > 21)
            {
                return "player";
            }
            if (playerTotal == dealerTotal)
            {
                return "draw";
            }
            return "dealer";
        }
    }
}