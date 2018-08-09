Feature: MultiPlayerCricket
	In order to enjoy the multiplayer cricket competition
	As a player
	I want to be told the winner of game

@mytag
    Scenario: PlayerFirst and PlayerSecond score is zero when game starts	
	When  PlayerFirst and PlayerSecond starts a game of cricket
	Then  PlayerFirst and PlayerSecond scores should be 0


	Scenario: PlayerFirst should be able to score runs	
	Given  Cricket game has started
	When PlayerFirst scores 4 runs
	Then  PlayerFirst scores should be 4

	Scenario: PlayerSecond should be able to score runs	
	Given  Cricket game has started
	When PlayerSecond scores 3 runs
	Then  PlayerSecond scores should be 3


	
	Scenario: PlayerFirst should be able to score multiple runs	
	Given  Cricket game has started
	And PlayerFirst has scored 4 runs
    When PlayerFirst scores 3 runs
	Then  PlayerFirst scores should be 7

	
	
	Scenario: PlayerSecond should be able to score multiple runs	
	Given  Cricket game has started
	And PlayerSecond has scored 3 runs
	When PlayerSecond scores 6 runs
	Then  PlayerSecond scores should be 9



	Scenario: PlayerFirst should not be able to score runs after getting out
	Given  Cricket game has started
	And PlayerFirst has scored 4 runs
	And PlayerFirst gets out

	When  PlayerFirst scores 3 runs
	Then  PlayerFirst scores should be 4

	Scenario: PlayerSecond should not be able to score runs after getting out
	Given  Cricket game has started
	And PlayerSecond has scored 3 runs
	And PlayerSecond gets out
	When  PlayerSecond scores 6 runs
	Then  PlayerSecond scores should be 3


	Scenario: PlayerSecond is winner
	Given  Cricket game has started
	And PlayerSecond has scored 9 runs
	And PlayerFirst has scored  6 runs
	Then  PlayerSecond is winner

	
	Scenario: PlayerFirst is winner
	Given  Cricket game has started
	And PlayerFirst has scored 6 runs
	And PlayerSecond has scored 3 runs
	Then PlayerFirst is winner

    Scenario: Match is tie
	Given  Cricket game has started
	And PlayerFirst has scored 6 runs
	And PlayerSecond has scored 6 runs
	Then  Match is tie