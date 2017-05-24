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

        internal void RunSync()
        {
            this.RunTrack();
            Thread.Sleep(1000);
            while (!this.Robot.Drive.Done)
            {
                Thread.Sleep(50);
                var isAnObstacleBlockingThePath = this.obstacleDetector.IsAnObstacleBlockingThePath();
                if (isAnObstacleBlockingThePath)
                {
                    return;
                }
            }
        }

        protected abstract void RunTrack();
    }
}
