using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace RobotWars.AcceptanceTests.Steps
{
    public static class TableExtensions
    {
        public static IEnumerable<string> AsRoverCommands(this Table table)
        {
            return table.Rows.Select(command => command.Values.FirstOrDefault());
        }
    }
}