# RobotMovementProject
A software for controlling robots in a factory. The robots are provided by a third party who also provide a .Net SDK for controlling their robots. The SDK defines:

Interface IRobot
{
Move(double distance);
Turn(double angle);
Beep();
}

The SDK also contains a class called ‘Robot’ which provides a concrete implementation of the IRobot interface. You cannot make any changes to the SDK.

A system has been designed so that factory workers can send the commands to the robots in the factory. Design a simple solution for the following problem:

Using simple classes, ensure that all commands sent to any robot by a human operator are sent to the robot that the factory worker wants to control, but also stored in memory so that they can be replayed for any number of similar robots. Consider which design pattern or patterns would allow you to do this in a simple, testable fashion.
