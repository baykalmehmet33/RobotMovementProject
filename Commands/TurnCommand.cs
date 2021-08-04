using RobotMovementProject.RobotSDK;

namespace RobotMovementProject.Commands
{
    public class TurnCommand : ICommand
    {
        public double Angle { get; set; }

        public void Execute(IRobot robot)
        {
            robot.Turn(Angle);
        }
    }
}
