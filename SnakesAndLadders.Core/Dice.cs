using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Core
{
    public class Dice : IDice
    {
        public int LastNumber { get; private set; }
        private readonly Random _dice;
        public Dice()
        {
            _dice = new Random();
        }
        public int Roll()
        {

            LastNumber = _dice.Next(1, 7);
            return LastNumber;
        }
    }
}
