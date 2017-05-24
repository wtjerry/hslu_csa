using System.Collections.Generic;
using RobotCtrl;
using Testat2.Tracks;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    internal class TrackCreator
    {
        private readonly Robot robot;
        private const string TracklineCommandName = "TrackLine ";
        private const string TrackTurnLeftCommandName = "TrackTurnLeft ";
        private const string TrackTurnRightCommandName = "TrackTurnRight ";
        private const string TrackArcLeftCommandName = "TrackArcLeft ";
        private const string TrackArcRightCommandName = "TrackArcRight ";

        public TrackCreator(Robot robot)
        {
            this.robot = robot;
        }

        internal Track CreateTrack(string trackAsString)
        {
            if (trackAsString.StartsWith(TracklineCommandName))
            {
                var argument = trackAsString.Substring(TracklineCommandName.Length);
                var distance = float.Parse(argument);
                var track = new Line(this.robot, distance);
                return track;
            }
            if (trackAsString.StartsWith(TrackTurnLeftCommandName))
            {
                var argument = trackAsString.Substring(TrackTurnLeftCommandName.Length);
                var angle = int.Parse(argument);
                var track = new TurnLeft(this.robot, angle);
                return track;
            }
            if (trackAsString.StartsWith(TrackTurnRightCommandName))
            {
                var argument = trackAsString.Substring(TrackTurnRightCommandName.Length);
                var angle = int.Parse(argument);
                var track = new TurnRight(this.robot, angle);
                return track;
            }
            if (trackAsString.StartsWith(TrackArcLeftCommandName))
            {
                var argumentsAsString = trackAsString.Substring(TrackArcLeftCommandName.Length);
                var arguments = argumentsAsString.Split(' ');
                var angle = int.Parse(arguments[0]);
                var radius = float.Parse(arguments[1]);
                var track = new ArcLeft(this.robot, angle, radius);
                return track;
            }
            if (trackAsString.StartsWith(TrackArcRightCommandName))
            {
                var argumentsAsString = trackAsString.Substring(TrackArcRightCommandName.Length);
                var arguments = argumentsAsString.Split(' ');
                var angle = int.Parse(arguments[0]);
                var radius = float.Parse(arguments[1]);
                var track = new ArcRight(this.robot, angle, radius);
                return track;
            }

            return new NullTrack(this.robot);
        }
    }
}