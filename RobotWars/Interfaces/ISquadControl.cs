using System.Collections.Generic;

namespace RobotWars.Interfaces
{
    public interface ISquadControl
    {
        void SendCommand(IEnumerable<string> input);
    }
}
