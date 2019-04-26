using NUnit.Framework;
using RobotWars.Handlers;

namespace RobotWars.UnitTests.Handler
{
    [TestFixture]
    public class RightInstructionHandlerTests
    {
        private readonly RightInstructionHandler _rightInstructionHandler = new RightInstructionHandler();

        [TestCase(Orientation.N, Orientation.E)]
        [TestCase(Orientation.W, Orientation.N)]
        [TestCase(Orientation.S, Orientation.W)]
        [TestCase(Orientation.E, Orientation.S)]
        public void Should_move_from_given_orientation_to__next_orientation(Orientation orientation, Orientation expectedOrientation)
        {
            //Given
            var position = new Position { Orientation = orientation };
            //When
            _rightInstructionHandler.Execute(position);

            //Then
            Assert.That(position.Orientation, Is.EqualTo(expectedOrientation), "Did not moved in expected direction");
        }
    }
}