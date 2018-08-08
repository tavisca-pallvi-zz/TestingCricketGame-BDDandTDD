Feature: MultiPlayerCricketGame
	In order to have multiplayer cricketgame
	As a player
	I want to know the winner of game

@mytag
Scenario:Playerf and Players score is zero when game starts	
	When  Playerf and Players has started  game of cricket
	Then  Playerf and Players score should be 0


Scenario: Player should be able to score runs
	Given Playerf has started a game of cricket
	When  Playerf scores 4 runs
	Then  Playerf score should be 4
