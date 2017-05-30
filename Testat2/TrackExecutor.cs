using System;
using System.Collections.Generic;
using System.Threading;
using RobotCtrl;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    internal class TrackExecutor
    {
        private readonly Robot robot;

        internal TrackExecutor(Robot robot)
        {
            this.robot = robot;
        }

        internal string ExecuteTracks(IEnumerable<Track> tracks)
        {
            var trackData = string.Empty;
            this.InitializeMotor();

            foreach (var track in tracks)
            {
                Console.WriteLine("RunSync started");
                var newTrackData = track.RunSync();
                trackData = $"{trackData} {newTrackData}";
                Console.WriteLine("RunSync ended");
            }

            Console.WriteLine("All tracks finished.");
            this.ResetMotor();
            Console.WriteLine("Motor resetted.");

            return trackData;
        }

        private void InitializeMotor()
        {
            this.robot.Position = new PositionInfo(0, 0, 0);
            this.robot.Drive.DriveCtrl.PowerLeft = false;
            Thread.Sleep(10);
            this.robot.Drive.DriveCtrl.PowerRight = false;
            Thread.Sleep(10);
            this.robot.Drive.DriveCtrl.PowerLeft = true;
            Thread.Sleep(10);
            this.robot.Drive.DriveCtrl.PowerRight = true;

            Thread.Sleep(10);

            this.robot.Drive.MotorCtrlLeft.ResetTicks();

            Thread.Sleep(10);
        }

        private void ResetMotor()
        {
            this.robot.Position = new PositionInfo(0, 0, 0);
            this.robot.Drive.MotorCtrlLeft.ResetTicks();
            this.robot.Drive.DriveCtrl.PowerLeft = false;
            this.robot.Drive.DriveCtrl.PowerRight = false;
        }
    }
}