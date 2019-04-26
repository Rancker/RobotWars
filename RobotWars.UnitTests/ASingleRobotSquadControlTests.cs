using Moq;
using NUnit.Framework;
using RobotWars.Interfaces;
using System.Linq;

namespace RobotWars.UnitTests
{
    public class ASingleRobotSquadControlTests
    {

        [TestCase("5 5\n1 1 N\nM", "1 2 N")]
        [TestCase("4 4\n0 0 N\nMR", "0 1 E")]
        [TestCase("2 2\n0 0 N\nMM", "0 1 N")]
        public void Should_set_on_expected_direction_when_only_one_robot_moves(string inputList, string expectedOutput)
        {
            //Given
            var mockOutput = new Mock<IOutput>();
            var roverSquadControl = new SquadControl(mockOutput.Object);
            var input = inputList.Split('\n').ToList();

            //When
            roverSquadControl.SendCommand(input);

            //Then
            mockOutput.Verify(output => output.Debug(It.Is<string>(outputValue => outputValue == expectedOutput)));
        }
    }
}
