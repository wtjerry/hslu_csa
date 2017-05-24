using RobotCtrl;
using Testat2.Tracks;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    internal class TrackCreator
    {
        private readonly TrackFactory trackFactory;

        private const string TracklineCommandName = "TrackLine ";
        private const string TrackTurnLeftCommandName = "TrackTurnLeft ";
        private const string TrackTurnRightCommandName = "TrackTurnRight ";
        private const string TrackArcLeftCommandName = "TrackArcLeft ";
        private const string TrackArcRightCommandName = "TrackArcRight ";

        public TrackCreator(TrackFactory trackFactory)
        {
            this.trackFactory = trackFactory;
        }

        internal Track CreateTrack(string trackAsString)
        {
            if (trackAsString.StartsWith(TracklineCommandName))
            {
                return CreateLine(trackAsString);
            }
            if (trackAsString.StartsWith(TrackTurnLeftCommandName))
            {
                return CreateTurnLeft(trackAsString);
            }
            if (trackAsString.StartsWith(TrackTurnRightCommandName))
            {
                return CreateTurnRight(trackAsString);
            }
            if (trackAsString.StartsWith(TrackArcLeftCommandName))
            {
                return CreateArcLeft(trackAsString);
            }
            if (trackAsString.StartsWith(TrackArcRightCommandName))
            {
                return CreateArcRight(trackAsString);
            }

            return this.trackFactory.CreateNullTrack();
        }

        private Track CreateLine(string trackAsString)
        {
            var argument = trackAsString.Substring(TracklineCommandName.Length);
            var distance = float.Parse(argument);
            return this.trackFactory.CreateLine(distance);
        }

        private Track CreateTurnLeft(string trackAsString)
        {
            var argument = trackAsString.Substring(TrackTurnLeftCommandName.Length);
            var angle = int.Parse(argument);
            return this.trackFactory.CreateTurnLeft(angle);
        }

        private Track CreateTurnRight(string trackAsString)
        {
            var argument = trackAsString.Substring(TrackTurnRightCommandName.Length);
            var angle = int.Parse(argument);
            return this.trackFactory.CreateTurnRight(angle);
        }

        private Track CreateArcLeft(string trackAsString)
        {
            var argumentsAsString = trackAsString.Substring(TrackArcLeftCommandName.Length);
            var arguments = argumentsAsString.Split(' ');
            var angle = int.Parse(arguments[0]);
            var radius = float.Parse(arguments[1]);
            return this.trackFactory.CreateArcLeft(angle, radius);
        }

        private Track CreateArcRight(string trackAsString)
        {
            var argumentsAsString = trackAsString.Substring(TrackArcRightCommandName.Length);
            var arguments = argumentsAsString.Split(' ');
            var angle = int.Parse(arguments[0]);
            var radius = float.Parse(arguments[1]);
            return this.trackFactory.CreateArcRight(angle, radius);
        }
    }
}