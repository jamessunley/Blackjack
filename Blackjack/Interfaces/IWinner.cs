namespace Blackjack
{
    public interface IWinner
    {
        string Calculate(int playerTotal, int dealerTotal);
    }
}