using System;
using TechTalk.SpecFlow;
using CricketGame;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]

    public class MultiPlayerCricketSteps
    {
        private Cricket _playerFirst=null, _playerSecond=null;
      

        [When(@"PlayerFirst and PlayerSecond starts a game of cricket")]
        [Given(@" Cricket game has started")]
        public void When_playerFirstAndPlayerSecondStartsAGameOfCricket()
        {
            _playerFirst = new Cricket();
            _playerSecond= new Cricket();

        }
        
        [Then(@"PlayerFirst and PlayerSecond scores should be (.*)")]
        public void ThenPlayerFirstAndPlayerSecondScoresShouldBe(int scores)
        {
            _playerFirst.PlayerScore.Should().Be(scores);
            _playerSecond.PlayerScore.Should().Be(scores);
        }

       
        [When(@"PlayerFirst scores (.*) runs")]
        public void WhenPlayerFirstScoresRuns(int scores)
        {
           
            _playerFirst.Score(scores);
        }

        [Then(@"PlayerFirst scores should be (.*)")]
        public void ThenPlayerFirstScoresShouldBe(int scores)
        {
            _playerFirst.PlayerScore.Should().Be(scores);
        }

      
        [When(@"PlayerSecond scores (.*) runs")]
        public void WhenPlayerSecondScoresRuns(int scores)
        {
            
                _playerSecond.Score(scores);
        }

        [Then(@"PlayerSecond scores should be (.*)")]
        public void ThenPlayerSecondScoresShouldBe(int scores)
        {
           _playerSecond.PlayerScore.Should().Be(scores);
        }

        [Given(@"Cricket game has started")]
        public void GivenCricketGameHasStarted()
        {
            _playerFirst = new Cricket();
            _playerSecond = new Cricket();
        }

        [Given(@"PlayerFirst has scored (.*) runs")]
        public void GivenPlayerFirstHasScoredRuns(int scores)
        {
            _playerFirst.Score(scores);
        }

        [Given(@"PlayerSecond has scored (.*) runs")]
        public void GivenPlayerSecondHasScoredRuns(int scores)
        {
            _playerSecond.Score(scores);
        }

        [Given(@"PlayerFirst gets out")]
        public void GivenPlayerFirstGetsOut()
        {
            _playerFirst.GetOut();
        }
        [Given(@"PlayerSecond gets out")]
        public void GivenPlayerSecondGetsOut()
        {
            _playerSecond.GetOut();
        }

        [Then(@"PlayerSecond is winner")]
        public void ThenPlayerSecondIsWinner()
        {
            _playerSecond.Winner(_playerFirst);
            _playerSecond.isWinner.Should().Be(true);
        }

        [Then(@"PlayerFirst is winner")]
        public void ThenPlayerFirstIsWinner()
        {
            _playerSecond.Winner(_playerFirst);
            _playerFirst.isWinner.Should().Be(true);
        }

       


        [Then(@"Match is tie")]
        public void ThenMatchIsTie()
        {

            _playerSecond.Winner(_playerFirst);
            _playerFirst.isWinner.Should().Be(true);
            _playerSecond.isWinner.Should().Be(true);

        }


    }
}
