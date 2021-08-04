using RobotMovementProject.Commands;
using RobotMovementProject.RobotSDK;

namespace RobotMovementProject
{
    public class RobotController: IRobotController
    {
        private IRobot _robot;
        private ICommand[] _theLastCommands;

        public void SetRobot(IRobot robot)
        {
            _robot = robot;
        }

        public void ExecuteCommands(ICommand[] commands)
        {
            foreach (var command in commands)
            {
                command.Execute(_robot);
            }
            _theLastCommands = commands;
        }

        public void RepeatTheLastCommands()
        {
            ExecuteCommands(_theLastCommands);
        }
    }
}
