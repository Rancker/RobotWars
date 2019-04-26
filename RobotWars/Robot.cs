using RobotWars.Handlers;
using RobotWars.Interfaces;
using System.Collections.Generic;

namespace RobotWars
{
    public class Robot
    {
        private readonly IOutput _output;
        public Position CurrentPosition { get; }
        private Dictionary<Instruction, IInstructionHandler> _availableHandlers;

        public Robot(Position startingPosition, IOutput output)
        {
            _output = output;
            CurrentPosition = startingPosition;
            LoadInstructionHandler();
        }

        private void LoadInstructionHandler()
        {
            _availableHandlers = new Dictionary<Instruction, IInstructionHandler>
            {
                {Instruction.L, new LeftInstructionHandler()},
                {Instruction.R, new RightInstructionHandler()},
                {Instruction.M, new MoveInstructionHandler()}
            };
        }
        public void Send(Instruction instruction)
        {
            _availableHandlers[instruction].Execute(CurrentPosition);
            _output.Debug($"{CurrentPosition}");
        }
    }
}