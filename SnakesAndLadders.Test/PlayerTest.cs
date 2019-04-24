using System;
using NUnit.Framework;
using SnakesAndLadders.Core;

namespace SnakesAndLadders.Test
{
    [TestFixture]
    public class PlayerTest
    {
        //Given the game is started
        //When the player rolls a die
        //Then the result should be between 1-6 inclusive

        [Test]
        public void Test_Player_Role_Dice_And_Result_Is_Between_1_And_6()
        {
            var dice = new Dice();
            var token = new Token();
            var player = new Player(dice, token);

            player.RollDice();
            if (player.Dice.LastNumber >= 1 && player.Dice.LastNumber <= 6)
                Assert.Pass();
            else
                Assert.Fail();
        }

        //Given the player rolls a 4
        //When they move their token
        //Then the token should move 4 spaces
        [Test]
        public void Test_Player_Role_As_4_And_Move_Then_Token_Is_In_Square()
        {
            var dice = new Dice();
            var token = new Token();
            var player = new Player(dice, token);

            player.TokenMove(4);

            Assert.AreEqual(5, player.Token.CurrentSquare);
        }
        //Given the token is on square 97
        //When the token is moved 3 spaces
        //Then the token is on square 100
        //And the player has won the game

        [Test]
        public void Test_Player_Token_On_97_Token_Moved_3_And_Player_Won()
        {
            var dice = new Dice();
            var token = new Token();
            var player = new Player(dice, token);

            player.TokenMove(96);
            player.TokenMove(3);

            Assert.IsTrue(player.HasWon);
        }

        //Given the token is on square 97
        //When the token is moved 4 spaces
        //Then the token is on square 97
        //And the player has not won the game
        [Test]
        public void Test_Player_Token_On_97_Token_Moved_4_And_Player_Not_Won()
        {
            var dice = new Dice();
            var token = new Token();
            var player = new Player(dice, token);

            player.TokenMove(96);
            player.TokenMove(4);

            Assert.IsFalse(player.HasWon);
        }
    }
}
