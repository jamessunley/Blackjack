namespace Blackjack
{
    public class Bust : IBust
    {
        public bool Calculate(int total)
        {
            if(total <= 21)
            {
                return false;
            }
            return true;
        }
    }
}