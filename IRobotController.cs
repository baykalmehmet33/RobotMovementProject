using RobotMovementProject.Commands;
using RobotMovementProject.RobotSDK;

namespace RobotMovementProject
{
    public interface IRobotController
    {
        void SetRobot(IRobot robot);
        void ExecuteCommands(ICommand[] commands);
        void RepeatTheLastCommands();
    }
}