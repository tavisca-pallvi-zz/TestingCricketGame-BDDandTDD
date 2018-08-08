using System;
using TechTalk.SpecFlow;
using CricketGame;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]
    public class MultiPlayerCricketGameSteps
    {
        private Cricket _playerf,_players;
        private bool flag;
        [When(@"Playerf and Players starts a game of cricket")]
        public void WhenPlayerfAndPlayersStartsAGameOfCricket()
        {
            _playerf = new Cricket();
            _players=new Cricket();
            flag = true;
        }
        
        [Then(@"Playerf and Players score should be (.*)")]
        public void ThenPlayerfAndPlayersScoreShouldBe(int score)
        {
            _playerf.PlayerScore.Should().Be(score);
            _players.PlayerScore.Should().Be(score);
        }

    }
}
