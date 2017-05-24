using System;
using System.Collections.Generic;
using System.IO;
using RobotCtrl;
using Testat2.Tracks;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    internal class SavedTracksExecutor
    {
        private readonly TrackStorage trackStorage;
        private readonly Robot robot;
        private const string TracklineCommandName = "TrackLine ";
        private const string TrackTurnLeftCommandName = "TrackTurnLeft ";
        private const string TrackTurnRightCommandName = "TrackTurnRight ";
        private const string TrackArcLeftCommandName = "TrackArcLeft ";
        private const string TrackArcRightCommandName = "TrackArcRight ";

        internal SavedTracksExecutor(TrackStorage trackStorage, Robot robot)
        {
            this.trackStorage = trackStorage;
            this.robot = robot;
        }

        internal void ExecuteSavedTracks()
        {
            var tracksAsSring = this.trackStorage.LoadTracks();

            var tracksAsStringList = tracksAsSring.Replace("\r", "").Split('\n');
            var tracks = this.ConvertStringToTracks(tracksAsStringList);

            this.ExecuteTracks(tracks);
        }

        private IEnumerable<Track> ConvertStringToTracks(IEnumerable<string> commandsAsString)
        {
            var tracks = new List<Track>();
            foreach (var s in commandsAsString)
            {
                if (s.StartsWith(TracklineCommandName))
                {
                    var argument = s.Substring(TracklineCommandName.Length);
                    var distance = float.Parse(argument);
                    var track = new Line(this.robot, distance);
                    tracks.Add(track);
                }

                else if (s.StartsWith(TrackTurnLeftCommandName))
                {
                    var argument = s.Substring(TrackTurnLeftCommandName.Length);
                    var angle = int.Parse(argument);
                    var track = new TurnLeft(this.robot, angle);
                    tracks.Add(track);
                }

                else if (s.StartsWith(TrackTurnRightCommandName))
                {
                    var argument = s.Substring(TrackTurnRightCommandName.Length);
                    var angle = int.Parse(argument);
                    var track = new TurnRight(this.robot, angle);
                    tracks.Add(track);
                }

                else if (s.StartsWith(TrackArcLeftCommandName))
                {
                    var argumentsAsString = s.Substring(TrackArcLeftCommandName.Length);
                    var arguments = argumentsAsString.Split(' ');
                    var angle = int.Parse(arguments[0]);
                    var radius = float.Parse(arguments[1]);
                    var track = new ArcLeft(this.robot, angle, radius);
                    tracks.Add(track);
                }

                else if (s.StartsWith(TrackArcRightCommandName))
                {
                    var argumentsAsString = s.Substring(TrackArcRightCommandName.Length);
                    var arguments = argumentsAsString.Split(' ');
                    var angle = int.Parse(arguments[0]);
                    var radius = float.Parse(arguments[1]);
                    var track = new ArcRight(this.robot, angle, radius);
                    tracks.Add(track);
                }
            }

            return tracks;
        }

        private void ExecuteTracks(IEnumerable<Track> tracks)
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