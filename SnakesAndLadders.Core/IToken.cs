namespace SnakesAndLadders.Core
{
    public interface IToken
    {
        int CurrentSquare { get; }

        void Move(int spaces);
    }
}