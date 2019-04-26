using NUnit.Framework;
using RobotWars.Exceptions;
using RobotWars.Parsers;

namespace RobotWars.UnitTests.Parsers
{
    [TestFixture]
    public class ParsePositionTests
    {
        [Test]
        public void Should_throw_exception_when_given_invalid_position_input_string()
        {
            const string invalidPositionString = "THIS IS NOT A VALID POSITION";
            var exception = Assert.Throws<CouldNotParsePositionException>(() => ParsePosition.From(invalidPositionString));
            Assert.That(exception.Message, Is.EqualTo("Could not parse position from: " + invalidPositionString));
        }
    }
}
