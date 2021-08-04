using RobotMovementProject.RobotSDK;

namespace RobotMovementProject.Commands
{
    public class MoveCommand : ICommand
    {
        public double Distance { get; set; }

        public void Execute(IRobot robot)
        {
            robot.Move(Distance);
        }
    }
}
