using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RobotWars.AcceptanceTests.Helpers
{
    public class SquadControlApp
    {
        private readonly Process _squadControlApp;


        public SquadControlApp()
        {
            _squadControlApp = new Process();
            _squadControlApp.StartInfo.UseShellExecute = false;

            _squadControlApp.StartInfo.RedirectStandardOutput = true;
            _squadControlApp.StartInfo.RedirectStandardInput = true;
            _squadControlApp.StartInfo.RedirectStandardError = true;
            _squadControlApp.StartInfo.FileName = "RobotWars.SquadControlApp.exe";
            _squadControlApp.Start();
            //_squadControlApp.WaitForExit();

        }

        public void InputCommand(string command)
        {
            _squadControlApp.StandardInput.WriteLine(command);
        }

        public string GetOutput()
        {
            var output = _squadControlApp.StandardOutput.ReadToEnd();
            Console.WriteLine(_squadControlApp.StandardError.ReadToEnd());

            return output.Trim();
        }

        public void InputCommands(IEnumerable<string> commands)
        {
            foreach (var command in commands)
            {
                InputCommand(command);
            }
        }

        public IEnumerable<string> GetOutputAsCollection()
        {
            var output = GetOutput();
            var outputAsCollection = Regex.Split(output, "\r\n");
            return outputAsCollection;
        }
    }
}