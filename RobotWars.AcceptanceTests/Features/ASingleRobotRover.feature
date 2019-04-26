Feature: A Single Robot Rover
	In order to control a rover, 
	As NASA 
	I want to sends a simple string of letters to the RoverSquadControl

@acceptance
Scenario: Control 1 Rover in a 5x5 Plateau
	Given I have a RoverRoverSquadControl
	And I enter the command 5 5
	And I enter the command 1 1 N
	And I enter the command M
	When I enter the GO command
	Then the output should be 1 2 N

@acceptance
Scenario: Control 1 Rover in a 4x4 Plateau
	Given I have a RoverRoverSquadControl
	And I enter the command 4 4
	And I enter the command 0 0 N
	And I enter the command MR
	When I enter the GO command
	Then the output should be 0 1 E

@ignore
Scenario: A Rover that goes out of bounds
	Given I have a RoverRoverSquadControl
	And I enter the command 2 2
	And I enter the command 0 0 N
	And I enter the command MM
	When I enter the GO command
	Then the output should be 0 1 N
