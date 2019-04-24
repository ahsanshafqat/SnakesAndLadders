﻿using System;

namespace SnakesAndLadders.Core
{
    
    public class Token : IToken
    {
        public Token()
        {
            CurrentSquare = 1;
        }

        public int CurrentSquare { get; private set; }

        public void Move(int spaces)
        {
            if (CurrentSquare + spaces <= 100)
            {
                CurrentSquare += spaces;
            }
            
        }
    }
}

