Robot Wars
=========

  A fleet of hand built robots are due to engage in battle for the annual “Robot Wars” competition. 
  Each robot will be placed within a rectangular battle arena and will navigate their way around the arena using a built in computer   system.  
  A robot’s location and heading is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. 
  The arena is divided up into a grid to simplify navigation. An example position might be 0, 0, N which means the robot is in the bottom left corner and facing North.  
  
  In order to control a robot, the competition organisers have provided a console for sending a simple string of letters to the on-board navigation system. 
  The possible letters are ‘L’, ‘R’ and ‘M’. ‘L’ and ‘R’ make the robot spin 90 degrees to the left or right respectively without moving from its current spot while ‘M’ 
  means move forward one grid point and maintain the same heading. Assume that the square directly North from (x, y) is (x, y+1)
  
  Input The first line of input is the upper-right coordinates of the arena, the lower-left coordinates are assumed to be (0, 0). 
  The rest of the input is information pertaining to the robots that have been deployed. 
  Each robot has two lines of input - the first gives the robot’s position and the second
  is a series of instructions telling the robot how to move within the arena. 
  The position is made up of two integers and a letter separated by spaces, corresponding to the x and y coordinates and the robot’s orientation. 
  Each robot will finish moving sequentially, which means that the second robot won’t start to move until the first one has finished moving.
	

INPUT AND OUTPUT
 
Test Input:
5 5

1 2 N

LMLMLMLMM

3 3 E

MMRMMRMRRM
 
Expected Output:
1 3 N

5 1 E

Tools Used - .Net Framework 4.7, Visual Studio 2017, UnitTest - Nunit, Mocking - Moq, Acceptance Test - Specflow
Application includes a console application to test and it covers all the unit tests. 
Tried to make it simple and readable so we don't need any comments. 

Once the instruction passed it hits the Squad Control where it parses all the commands and move the positions and return back.

To run the console application enter the input once done enter GO to submit the information that will return the output.
EX INPUT-
5 5

1 2 N

LMLMLMLMM

3 3 E

MMRMMRMRRM

GO

OUTPUT - 
1 3 N

5 1 E

