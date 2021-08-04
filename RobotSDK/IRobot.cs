namespace RobotMovementProject.RobotSDK
{
    public interface IRobot
    {
        void Move(double distance);
        void Turn(double angle);
        void Beep();
    }
}
