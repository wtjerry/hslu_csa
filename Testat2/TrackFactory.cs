using RobotCtrl;
using Testat2.Tracks;

namespace Testat2
{
    internal class TrackFactory
    {
        private readonly Robot robot;

        internal TrackFactory(Robot robot)
        {
            this.robot = robot;
        }

        internal Line CreateLine(float distance)
        {
            return new Line(this.robot, distance);
        }

        internal TurnLeft CreateTurnLeft(int angle)
        {
            return new TurnLeft(this.robot, angle);
        }

        internal TurnRight CreateTurnRight(int angle)
        {
            return new TurnRight(this.robot, angle);
        }

        internal ArcLeft CreateArcLeft(int angle, float radius)
        {
            return new ArcLeft(this.robot, angle, radius); 
        }

        internal ArcRight CreateArcRight(int angle, float radius)
        {
            return new ArcRight(this.robot, angle, radius);
        }

        internal NullTrack CreateNullTrack()
        {
            return new NullTrack(this.robot);
        }
    }
}
