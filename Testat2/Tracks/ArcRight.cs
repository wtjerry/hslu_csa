﻿using RobotCtrl;

namespace Testat2.Tracks
{
    internal class ArcRight : Track
    {
        private readonly float angle;
        private readonly float radius;

        internal ArcRight(Robot robot, float angle, float radius) : base(robot)
        {
            this.angle = angle;
            this.radius = radius;
        }

        protected override void RunTrack()
        {
            this.Robot.Drive.RunArcRight(this.radius, this.angle, this.Speed, this.Acceleration);
        }
    }
}