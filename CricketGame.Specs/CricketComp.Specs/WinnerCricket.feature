Feature: WinnerCricket
    In order to enjoy a game of cricket
	As a player
	I want to be told my score
@mytag
Scenario: 
	Given Scenario: Player score is zero when game starts	
	When  Player starts a game of cricket
	Then the player score should be 0

Scenario: Player should be able to score runs
	Given Player has started a game of cricket
	When  Player scores 4 runs
	Then  Player score should be 4
	
Scenario: Player should be able to score run multiple times
	Given Player has started a game of cricket
    Given Player has scored 4 runs
	When  Player scores 3 runs
	Then  Player score should be 7
	
	And 
	When 
	Then 
