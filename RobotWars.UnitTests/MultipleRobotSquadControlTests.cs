using Moq;
using NUnit.Framework;
using RobotWars.Interfaces;
using System.Linq;

namespace RobotWars.UnitTests
{
    public class MultipleRobotSquadControlTests
    {

        [TestCase("5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM", "1 3 N", "5 1 E")]
        public void Should_set_on_expected_direction_when_two_robot_moves(string inputList, string expectedFirstRobotPosition, string expectedSecondRobotPosition)
        {
            //Given
            var mockOutput = new Mock<IOutput>();
            var roverSquadControl = new SquadControl(mockOutput.Object);
            var input = inputList.Split('\n').ToList();

            //When
            roverSquadControl.SendCommand(input);

            //Then

            mockOutput.Verify(output => output.Debug(It.Is<string>(outputValue => outputValue == expectedFirstRobotPosition)));
            mockOutput.Verify(output => output.Debug(It.Is<string>(outputValue => outputValue == expectedSecondRobotPosition)));
        }

        [TestCase("5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM\n0 0 E\nMMMMLM", "1 3 N", "5 1 E", "4 1 N")]
        public void Should_set_on_expected_direction_when_three_robot_moves(string inputList, string expectedFirstRobotPosition, string expectedSecondRobotPosition, string expectedThirdRobotPosition)
        {
            //Given
            var mockOutput = new Mock<IOutput>();
            var roverSquadControl = new SquadControl(mockOutput.Object);
            var input = inputList.Split('\n').ToList();

            //When
            roverSquadControl.SendCommand(input);

            //Then
            mockOutput.Verify(output => output.Debug(It.Is<string>(outputValue => outputValue == expectedFirstRobotPosition)));
            mockOutput.Verify(output => output.Debug(It.Is<string>(outputValue => outputValue == expectedSecondRobotPosition)));
            mockOutput.Verify(output => output.Debug(It.Is<string>(outputValue => outputValue == expectedThirdRobotPosition)));
        }
    }
}
