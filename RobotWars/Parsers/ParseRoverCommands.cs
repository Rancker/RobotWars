using RobotWars.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars.Parsers
{
    public class ParseRoverCommands
    {
        public static IEnumerable<RobotCommand> From(IEnumerable<string> inputCommands)
        {
            var roverCommands = inputCommands.Skip(1).ToList();

            if (!roverCommands.Any())
                throw new CouldNotParsePositionException("Could not parse any command");

            for (int i = 0; i < roverCommands.Count(); i += 2)
            {
                yield return new RobotCommand
                {
                    StartingPosition = ParsePosition.From(roverCommands[i]),
                    Instructions = ParseInstructions.From(roverCommands[i + 1])
                };
            }
        }

    }
}