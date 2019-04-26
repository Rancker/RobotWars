using RobotWars.Interfaces;

namespace RobotWars.Handlers
{
    public class RightInstructionHandler : IInstructionHandler
    {
        public void Execute(Position currentPosition)
        {
            switch (currentPosition.Orientation)
            {
                case Orientation.N:
                    currentPosition.Orientation = Orientation.E;
                    break;
                case Orientation.W:
                    currentPosition.Orientation = Orientation.N;
                    break;
                case Orientation.S:
                    currentPosition.Orientation = Orientation.W;
                    break;
                case Orientation.E:
                    currentPosition.Orientation = Orientation.S;
                    break;
            }
        }
    }
}