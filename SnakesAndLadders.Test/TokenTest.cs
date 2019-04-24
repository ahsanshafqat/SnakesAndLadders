using NUnit.Framework;
using System;
using SnakesAndLadders.Core;

namespace SnakesAndLadders.Test
{
    [TestFixture]
    public class TokenTest
    {
        //As a player
        //I want to be able to move my token
        //So that I can get closer to the goal

        //Given the game is started
        //When the token is placed on the board
        //Then the token is on square 1
        [Test]
        public void Test_Game_Started_And_Token_Is_On_1()
        {
            var token = new Token();

            Assert.AreEqual(1, token.CurrentSquare);
        }


        //Given the token is on square 1
        //When the token is moved 3 spaces
        //Then the token is on square 4

        [Test]
        public void Test_Token_Is_On_Square_1_And_Move_Token_3_And_Token_Is_On_Square_4()
        {
            var token = new Token();
            token.Move(3);

            Assert.AreEqual(4, token.CurrentSquare);
        }

        //Given the token is on square 1
        //When the token is moved 3 spaces
        //And then it is moved 4 spaces
        //Then the token is on square 8

        [Test]
        public void Test_Token_Is_On_Square_1_And_Move_Token_3_Then_Move_4_And_Token_Is_On_Square_8()
        {
            var token = new Token();
            token.Move(3);
            token.Move(4);

            Assert.AreEqual(8, token.CurrentSquare);
        }

       
    }
}
