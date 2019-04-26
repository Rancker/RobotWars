using RobotWars.Interfaces;
using System;

namespace RobotWars.SquadControlApp
{
    public class ConsoleOutput : IOutput
    {
        private readonly bool _debuggingEnabled;

        public ConsoleOutput(bool debuggingEnabled)
        {
            _debuggingEnabled = debuggingEnabled;
        }

        public void Debug(string line)
        {
            if (_debuggingEnabled)
                Console.WriteLine(line);
        }

        public void Write(string line)
        {
            Console.WriteLine(line);
        }
    }
}
