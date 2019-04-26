using System;

namespace RobotWars.Exceptions
{
    public class CouldNotParsePositionException : Exception
    {
        public CouldNotParsePositionException(string message) : base(message) { }
    }
}