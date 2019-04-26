using RobotWars.Exceptions;
using System.Text.RegularExpressions;

namespace RobotWars.Parsers
{
    public class ParseCoordinate
    {
        public static Coordinate From(string input)
        {
            if (!Regex.IsMatch(input, @"^\d \d$"))
                throw new InputBoundaryException(input + " is not a valid coordinate");

            var inputArray = input.Split(' ');

            return new Coordinate
            {
                X = int.Parse(inputArray[0]),
                Y = int.Parse(inputArray[1])
            };
        }
    }
}
