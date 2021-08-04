using RobotMovementProject.RobotSDK;

namespace RobotMovementProject.Commands
{
    public interface ICommand
    {
        void Execute(IRobot robot);
    }
}
