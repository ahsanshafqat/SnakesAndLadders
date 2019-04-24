using System;

namespace SnakesAndLadders.Core
{
    public class Player : IPlayer
    {
        private readonly IDice dice;
        private readonly IToken token;
        public IDice Dice { get { return this.dice; } }
        public IToken Token { get { return this.token; } }
        public bool HasWon { get; private set; }

        public Player(IDice dice, IToken token)
        {
            this.dice = dice;
            this.token = token;
        }

        public void RollDice()
        {
            this.dice.Roll();
        }

        public void TokenMove(int spaces)
        {
            this.token.Move(spaces);
            if (this.token.CurrentSquare == 100)
                HasWon = true;
        }
    }
}