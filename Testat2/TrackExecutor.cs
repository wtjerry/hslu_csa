using System;
using System.Collections.Generic;
using RobotCtrl;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    internal class TrackExecutor
    {
        private readonly Robot robot;
        private TrackRunner trackRunner;

        internal TrackExecutor(Robot robot)
        {
            this.robot = robot;
        }

        internal void ExecuteTracks(IEnumerable<Track> tracks)
        {
            this.InitializeMotor();

            foreach (var track in tracks)
            {
                Console.WriteLine("RunSync started");
                track.RunSync();
                Console.WriteLine("RunSync ended");
            }
        }

        private void InitializeMotor()
        {
            this.robot.Position = new PositionInfo(0, 0, 0);
            this.robot.Drive.DriveCtrl.PowerLeft = true;
            this.robot.Drive.DriveCtrl.PowerRight = true;
        }
    }
}