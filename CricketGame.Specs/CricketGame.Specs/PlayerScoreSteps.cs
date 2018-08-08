using System;
using TechTalk.SpecFlow;
using FluentAssertions;
namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        private bool f = true;

    
        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreIsZero(int score)
        {
            _game.PlayerScore.Should().Be(score);
           // ScenarioContext.Current.Pending();
        }
      

        [Given(@"Player has started a game of cricket")]
        [When(@"Player starts a game of cricket")]
        public void GivenPlayerHasStartedAGameOfCricket()
        {
            _game = new Cricket();
            f = true;
          //  ScenarioContext.Current.Pending();
        }

        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int score)
        {
            if(f==true)
            _game.Score(score);
          //  _game.PlayerScore.Should().Be(_game.PlayerScore);
           // ScenarioContext.Current.Pending();
        }


        [Then(@"Player score should be (.*)")]
        public void ThenPlayerScoreShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);

        }
        [Given(@"Player has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int score)
        {

            _game.Score(score);
            
        }

        [Given(@"Player gets out")]
      //  [When(@"Player scores (.*) runs")]
        public void GivenPlayerGetsOut()
        {
            f = false;

           // _game.Score(_game.PlayerScore);

        }

        


    }
}
