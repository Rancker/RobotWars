using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars.SquadControlApp
{
    class Program
    {
        private const string GoCommand = "GO";

        static void Main()
        {
            var squadControl = new SquadControl(new ConsoleOutput(false));
            squadControl.SendCommand(FromConsoleInput().ToList());
        }
        private static IEnumerable<string> FromConsoleInput()
        {
            string line;
            while (GoCommand != (line = Console.ReadLine()))
            {
                yield return line;
            }
        }
    }
}
