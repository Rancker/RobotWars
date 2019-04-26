using Moq;
using NUnit.Framework;
using RobotWars.Interfaces;

namespace RobotWars.UnitTests
{
    [TestFixture]
    public class RobotTests
    {
        [TestCase(Instruction.M, 0, 1, Orientation.N)]
        [TestCase(Instruction.L, 0, 0, Orientation.W)]
        [TestCase(Instruction.R, 0, 0, Orientation.E)]
        public void Should_be_able_to_go(Instruction instruction, int xCoordinate, int yCoordinate, Orientation orientation)
        {
            //Given
            var output = new Mock<IOutput>();
            var startingPosition = new Position()
            {
                Coordinate = new Coordinate(0, 0),
                Orientation = Orientation.N
            };
            var rover = new Robot(startingPosition, output.Object);
            //When
            rover.Send(instruction);
            //Then
            Assert.That(rover.CurrentPosition.Coordinate.X, Is.EqualTo(xCoordinate), " X Coordinate");
            Assert.That(rover.CurrentPosition.Coordinate.Y, Is.EqualTo(yCoordinate), " Y Coordinate");
            Assert.That(rover.CurrentPosition.Orientation, Is.EqualTo(orientation), "Orientation");
            var outputString = xCoordinate + " " + yCoordinate + " " + orientation;
            output.Verify(console => console.Debug(It.Is<string>(val => val == outputString)));
        }
    }
}
