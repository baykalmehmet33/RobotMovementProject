using RobotMovementProject.Commands;
using RobotMovementProject.RobotSDK;

namespace RobotMovementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotController robotController = new RobotController();

            robotController.SetRobot(new Robot());

            robotController.ExecuteCommands(new ICommand[] { new MoveCommand { Distance = 10 }, new TurnCommand { Angle = 45 }, new BeepCommand(), new TurnCommand { Angle = 90 } });

            System.Console.ReadLine();

            robotController.RepeatTheLastCommands();

            System.Console.ReadLine();
        }
    }
}
