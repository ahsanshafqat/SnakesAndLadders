namespace SnakesAndLadders.Core
{
    public interface IPlayer
    {
        IDice Dice { get; }
        bool HasWon { get; }
        IToken Token { get; }

        void RollDice();
        void TokenMove(int spaces);
    }
}