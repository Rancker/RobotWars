using RobotWars.Interfaces;

namespace RobotWars.Handlers
{
    public class MoveInstructionHandler : IInstructionHandler
    {
        public void Execute(Position currentPosition)
        {
            if (currentPosition.Orientation == Orientation.N)
                currentPosition.Coordinate.Y += 1;

            if (currentPosition.Orientation == Orientation.W)
                currentPosition.Coordinate.X -= 1;

            if (currentPosition.Orientation == Orientation.S)
                currentPosition.Coordinate.Y -= 1;

            if (currentPosition.Orientation == Orientation.E)
                currentPosition.Coordinate.X += 1;
        }
    }
}