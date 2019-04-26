using NUnit.Framework;
using RobotWars.Handlers;

namespace RobotWars.UnitTests.Handler
{
    [TestFixture]
    public class LeftInstructionHandlerTests
    {
        private readonly LeftInstructionHandler _leftInstructionHandler = new LeftInstructionHandler();

        [TestCase(Orientation.N, Orientation.W)]
        [TestCase(Orientation.W, Orientation.S)]
        [TestCase(Orientation.S, Orientation.E)]
        [TestCase(Orientation.E, Orientation.N)]
        public void Should_move_from_given_orientation_to__next_orientation(Orientation orientation, Orientation expectedOrientation)
        {
            //Given
            var position = new Position { Orientation = orientation };
            //When
            _leftInstructionHandler.Execute(position);

            //Then
            Assert.That(position.Orientation, Is.EqualTo(expectedOrientation), "Did not moved in expected direction");
        }
    }
}
