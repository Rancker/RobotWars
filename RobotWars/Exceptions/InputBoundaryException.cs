using System;

namespace RobotWars.Exceptions
{
    public class InputBoundaryException : Exception
    {
        public InputBoundaryException(string message) : base(message) { }
    }
}