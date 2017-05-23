using System;
using System.Threading;
using System.Xml.Serialization;
using RobotCtrl;

namespace Testat2.Tracks
{
    public abstract class Track
    {
        private readonly Robot robot;

        protected Track(Robot robot)
        {
            this.robot = robot;
            this.Acceleration = 0.3f;
            this.Speed = 0.5f;
        }

        public void RunSync()
        {
            this.RunTrack();
            Thread.Sleep(1000);
            while (!this.Robot.Drive.Done)
            {
                Thread.Sleep(50);
            }
        }

        protected abstract void RunTrack();

        protected Robot Robot
        {
            get { return robot; }
        }

        protected float Acceleration { get; private set; }
        protected float Speed { get; private set; }
    }
}
