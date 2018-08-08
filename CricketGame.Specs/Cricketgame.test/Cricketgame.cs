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
            var game = new Cricket();

            Assert.IsTrue(game.PlayerScore == 0);


        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 4);


        
    }
    [TestMethod]
    public void Score_InValidRuns_ShouldNotUpdatePlayerScore()
    {
        var game = new Cricket();
        game.Score(7);
        Assert.IsTrue(game.PlayerScore == 0);


    }
}
}
