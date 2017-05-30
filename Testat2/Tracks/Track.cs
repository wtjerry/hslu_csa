using System;
using System.Threading;
using System.Xml.Serialization;
using RobotCtrl;

namespace Testat2.Tracks
{
    internal abstract class Track
    {
        private readonly ObstacleDetector obstacleDetector;

        protected Track(Robot robot, ObstacleDetector obstacleDetector)
        {
            this.obstacleDetector = obstacleDetector;
            this.Robot = robot;
            this.Acceleration = 0.3f;
            this.Speed = 0.5f;
        }

        protected float Acceleration { get; private set; }

        protected float Speed { get; private set; }

        protected Robot Robot { get; private set; }

        internal string RunSync()
        {
            var trackData = string.Empty;
            this.RunTrack();
            Thread.Sleep(1000);
            while (!this.Robot.Drive.Done)
            {
                Thread.Sleep(500);
                trackData += GetTrackData();

                var isAnObstacleBlockingThePath = this.obstacleDetector.IsAnObstacleBlockingThePath();
                if (isAnObstacleBlockingThePath)
                {
                    this.Robot.Drive.DriveCtrl.PowerLeft = false;
                    this.Robot.Drive.DriveCtrl.PowerRight = false;
                    return trackData;
                }
            }

            return trackData;
        }

        private string GetTrackData()
        {
            var distanceLeftMotor = this.ConvertMotorTicksToDistance(this.Robot.Drive.MotorCtrlLeft.Ticks * -1);
            var distanceRightMotor = this.ConvertMotorTicksToDistance(this.Robot.Drive.MotorCtrlLeft.Ticks);

            return $"Distance motor left: {distanceLeftMotor}, Disance motor right {distanceRightMotor} | ";
        }

        private double ConvertMotorTicksToDistance(double motorTicks)
        {
            return motorTicks / 28700d * 23.87d;
        }

        protected abstract void RunTrack();
    }
}
