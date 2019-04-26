using RobotWars.Exceptions;
using RobotWars.Interfaces;
using RobotWars.Parsers;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class SquadControl : ISquadControl
    {
        private readonly IOutput _output;

        public SquadControl(IOutput output)
        {
            _output = output;
        }

        public void SendCommand(IEnumerable<string> input)
        {
            if (!input.Any()) throw new InvalidCommandException("Please provide valid command and position.");

            var rovers = new List<Robot>();
            var roverCommands = ParseRoverCommands.From(input);
            foreach (var roverCommand in roverCommands)
            {
                var robot = new Robot(roverCommand.StartingPosition, _output);
                foreach (var instruction in roverCommand.Instructions)
                {
                    robot.Send(instruction);
                }

                rovers.Add(robot);
                _output.Write(robot.CurrentPosition.ToString());
            }
        }
    }
}
