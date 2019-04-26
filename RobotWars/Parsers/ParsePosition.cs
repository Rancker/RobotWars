using RobotWars.Exceptions;
using System.Text.RegularExpressions;

namespace RobotWars.Parsers
{
    public class ParsePosition
    {
        public static Position From(string input)
        {
            if (!Regex.IsMatch(input, @"^\d \d [NSEW]$"))
                throw new CouldNotParsePositionException("Could not parse position from: " + input);

            var positionArray = input.Split(' ');
            return new Position
            {
                Coordinate = ParseCoordinate.From(positionArray[0] + " " + positionArray[1]),
                Orientation = ParseOrientation.From(positionArray[2])

            };
        }
    }
}