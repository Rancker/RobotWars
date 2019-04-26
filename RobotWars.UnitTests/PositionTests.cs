using NUnit.Framework;
using RobotWars.Parsers;

namespace RobotWars.UnitTests
{
    [TestFixture]
    public class PositionTests
    {

        [Test]
        public void Should_parse_position_from_string()
        {
            //Given
            var position = ParsePosition.From("1 2 N");

            //Then
            Assert.That(position.Coordinate.X, Is.EqualTo(1));
            Assert.That(position.Coordinate.Y, Is.EqualTo(2));
            Assert.That(position.Orientation, Is.EqualTo(Orientation.N));
        }

        [Test]
        public void Should_be_able_to_compare_using_equals()
        {
            //Given
            var firstPosition = new Position
            {
                Coordinate = new Coordinate(1, 1),
                Orientation = Orientation.E
            };
            var secondPosition = new Position
            {
                Coordinate = new Coordinate(1, 1),
                Orientation = Orientation.E
            };

            Assert.That(firstPosition, Is.EqualTo(secondPosition));
        }
    }
}
