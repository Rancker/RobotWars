using NUnit.Framework;

namespace RobotWars.UnitTests
{
    [TestFixture]
    public class CoordinateTests
    {
        [Test]
        public void Should_give_coordinates_0_0_by_default()
        {
            //Given
            var coordinate = new Coordinate();

            //Then
            Assert.That(coordinate.X, Is.EqualTo(0), "Default X Coordinate is not 0");
            Assert.That(coordinate.Y, Is.EqualTo(0), "Default Y Coordinate is not 0");
        }

        [Test]
        public void Should_give_coordinates_set_in_constructior()
        {
            //Given
            var coordinate = new Coordinate(1, 2);

            //Then
            Assert.That(coordinate.X, Is.EqualTo(1), "Default X Coordinate is not 1");
            Assert.That(coordinate.Y, Is.EqualTo(2), "Default Y Coordinate is not 2");
        }


        [Test]
        public void Should_be_able_to_compare_2_coordinates()
        {
            var firstCoordinate = new Coordinate(1, 2);
            var secondCoordinate = new Coordinate(1, 2);

            Assert.That(firstCoordinate, Is.EqualTo(secondCoordinate));
        }
    }
}
