Feature: MultipleMarsRovers
	In order to control multiple mars rovers, 
	As NASA 
	I want to sends a simple string of letters to the RoverSquadControl

@acceptance
Scenario: 5 x 5 Plateau with 2 Rovers
	Given I have a RoverRoverSquadControl
	When I send the the commands:
	| <Test Input> |
	| 5 5          |
	| 1 2 N        |
	| LMLMLMLMM    |
	| 3 3 E        |
	| MMRMMRMRRM   |
	When I enter the GO command
	Then the result should be
	| <Expected Output> |
	| 1 3 N             |
	| 5 1 E             |


Scenario: 5 x 5 Plateau with 3 Rovers
	Given I have a RoverRoverSquadControl
	When I send the the commands:
	| <Test Input> |
	| 5 5          |
	| 1 2 N        |
	| LMLMLMLMM    |
	| 3 3 E        |
	| MMRMMRMRRM   |
	| 0 0 E        |
	| MMMMLM      |
	When I enter the GO command
	Then the result should be
	| <Expected Output> |
	| 1 3 N             |
	| 5 1 E             |
	| 4 1 N             |
