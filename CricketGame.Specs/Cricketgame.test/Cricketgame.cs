using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CricketGame;

namespace Cricketgame.test
{
    [TestClass]
    public class Cricketgame
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldbeZero()
        {
            var player = new Cricket();
            Assert.IsTrue(player.PlayerScore == 0);
        }
        
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var player = new Cricket();
            player.Score(4);
            Assert.IsTrue(player.PlayerScore == 4);        
        }
 
     [TestMethod]
        public void Winner_OfGame_ShouldBe_PlayerSecond()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();
            player1.Score(8);
            player2.Score(9);
            player1.Winner(player2);
            Assert.IsTrue(player2.isWinner == true&& player1.isWinner == false);

        }

        [TestMethod]
        public void Winner_OfGame_ShouldBe_PlayerFirst()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();
            
            player1.Score(10);
            player2.Score(9);
            player1.Winner(player2);
            Assert.IsTrue(player1.isWinner == true&&player2.isWinner==false);
        }
        
        [TestMethod]
        public void Game_is_Tie()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();

            player1.Score(9);
            player2.Score(9);
            player1.Winner(player2);
            Assert.IsTrue(player1.isWinner == true&& player2.isWinner == true);
        }

        [TestMethod]
        public void Player_NotUpdateScore_GetOut()
        {
            var player = new Cricket();
           
            player.Score(9);
            player.GetOut();
            player.Score(10);
            Assert.IsTrue(player.PlayerScore == 9);
        }
    }
}
