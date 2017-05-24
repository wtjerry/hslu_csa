﻿using RobotCtrl;

namespace Testat2.Tracks
{
    internal class TurnLeft : Track
    {
        private readonly float angle;

        internal TurnLeft(Robot robot, float angle) : base(robot)
        {
            this.angle = angle;
        }

        protected override void RunTrack()
        {
            this.Robot.Drive.RunTurn(this.angle * -1, this.Speed, this.Acceleration);
        }
    }
}