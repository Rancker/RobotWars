using NUnit.Framework;
using TechTalk.SpecFlow;

namespace RobotWars.AcceptanceTests.Steps
{
    [Binding]
    public class RoverSteps
    {
        private Helpers.SquadControlApp _squadControlApp;


        [Given(@"I have a RobotSquadControl")]
        public void GivenIHaveARobotSquadControl()
        {
            _squadControlApp = new Helpers.SquadControlApp();
        }

        [When(@"I enter the (.*) command")]
        [Given(@"I enter the command (.*)")]
        public void GivenIEnterTheCommand(string command)
        {
            _squadControlApp.InputCommand(command);
        }

        [Then(@"the output should be (.*)")]
        public void ThenTheOutputShouldBe(string output)
        {
            Assert.That(_squadControlApp.GetOutput(), Is.EqualTo(output));
        }


        [When(@"I send the the commands:")]
        public void WhenISendTheTheCommands(Table table)
        {
            var commands = table.AsRoverCommands();
            _squadControlApp.InputCommands(commands);
        }

        [Then(@"the result should be")]
        public void ThenTheResultShouldBe(Table table)
        {
            var outputCollection = _squadControlApp.GetOutputAsCollection();
            var expected = table.AsRoverCommands();
            CollectionAssert.AreEqual(expected, outputCollection);
        }
    }
}
