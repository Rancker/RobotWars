using NUnit.Framework;
using RobotWars.Exceptions;
using RobotWars.Parsers;

namespace RobotWars.UnitTests.Parsers
{
    public class ParseCoordinateTests
    {
        [Test]
        public void Should_parse_string_5_6()
        {
            //Given
            var coordinateString = "5 6";
            //When
            var parsedCoordinate = ParseCoordinate.From(coordinateString);

            //Then
            Assert.That(parsedCoordinate.X, Is.EqualTo(5), "X Coordinate");
            Assert.That(parsedCoordinate.Y, Is.EqualTo(6), "Y Coordinate");
        }

        [TestCase("A B")]
        [TestCase("1 2 3")]
        public void Should__throw_error_for_invalid_coordinate_string(string coordinateString)
        {

            var exception = Assert.Throws<InputBoundaryException>(() => ParseCoordinate.From(coordinateString));

            Assert.That(exception.Message, Is.EqualTo(coordinateString + " is not a valid coordinate"), "Hasn't thrown exception when given an incorrect coordinate string");

        }


    }
}
