using NUnit.Framework;
using RobotWars.Handlers;

namespace RobotWars.UnitTests.Handler
{
    [TestFixture]
    public class MoveInstructionHandlerTests
    {
        private readonly MoveInstructionHandler _moveInstructionHandler = new MoveInstructionHandler();

        [TestCase(Orientation.N, 1, 1, 1, 2)]
        [TestCase(Orientation.W, 2, 2, 1, 2)]
        [TestCase(Orientation.S, 3, 3, 3, 2)]
        [TestCase(Orientation.E, 4, 4, 5, 4)]
        public void Should_move_from_given_coordinates_to__expected_coordinates(Orientation orientation, int xCoordinate, int yCoordinate, int expectedXCoordinate, int expectedYCoordinate)
        {
            //Given
            var position = new Position { Orientation = orientation, Coordinate = new Coordinate { X = xCoordinate, Y = yCoordinate } };
            //When
            _moveInstructionHandler.Execute(position);

            //Then
            Assert.That(position.Coordinate, Is.EqualTo(new Coordinate { X = expectedXCoordinate, Y = expectedYCoordinate }), "Coordinates didn't changed in the expected position.");
        }
    }
}