using NUnit.Framework;
using RobotWars.Parsers;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars.UnitTests.Parsers
{
    [TestFixture]
    public class RobotCommandParserTests
    {
        [Test]
        public void Should_return_1_RoverCommand()
        {
            //Given
            var commandStrings = new List<string> { "5 5", "1 1 N", "MM" };
            //When
            var roverCommands = ParseRobotCommands.From(commandStrings);

            //Then
            Assert.That(roverCommands.Count(), Is.EqualTo(1), "Should parser only 1 RoverCommand");

            var robotCommand = roverCommands.First();

            Assert.That(robotCommand.StartingPosition, Is.EqualTo(ParsePosition.From("1 1 N")));
        }

    }
}
