using System;

namespace RobotMovementProject.RobotSDK
{
    public class Robot : IRobot
    {
        public void Beep()
        {
            Console.WriteLine("Beep");
        }

        public void Move(double distance)
        {
            Console.WriteLine("Move -> " + distance);
        }

        public void Turn(double angle)
        {
            Console.WriteLine("Turn -> " + angle);
        }
    }
}
