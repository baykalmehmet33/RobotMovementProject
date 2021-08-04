using RobotMovementProject.RobotSDK;

namespace RobotMovementProject.Commands
{
    public class BeepCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Beep();
        }
    }
}
