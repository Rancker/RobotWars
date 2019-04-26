using RobotWars.Interfaces;

namespace RobotWars.Handlers
{
    public class LeftInstructionHandler : IInstructionHandler
    {
        public void Execute(Position currentPosition)
        {
            switch (currentPosition.Orientation)
            {
                case Orientation.N:
                    currentPosition.Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    currentPosition.Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    currentPosition.Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    currentPosition.Orientation = Orientation.N;
                    break;
            }
        }
    }
}