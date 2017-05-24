using RobotCtrl;
using Testat2.Tracks;

namespace Testat2
{
    internal class TrackFactory
    {
        private readonly Robot robot;
        private readonly ObstacleDetector obstacleDetector;

        public TrackFactory(Robot robot, ObstacleDetector obstacleDetector)
        {
            this.robot = robot;
            this.obstacleDetector = obstacleDetector;
        }

        internal Line CreateLine(float distance)
        {
            return new Line(this.robot, this.obstacleDetector, distance);
        }

        internal TurnLeft CreateTurnLeft(int angle)
        {
            return new TurnLeft(this.robot, this.obstacleDetector, angle);
        }

        internal TurnRight CreateTurnRight(int angle)
        {
            return new TurnRight(this.robot, this.obstacleDetector, angle);
        }

        internal ArcLeft CreateArcLeft(int angle, float radius)
        {
            return new ArcLeft(this.robot, this.obstacleDetector, angle, radius); 
        }

        internal ArcRight CreateArcRight(int angle, float radius)
        {
            return new ArcRight(this.robot, this.obstacleDetector, angle, radius);
        }

        internal NullTrack CreateNullTrack()
        {
            return new NullTrack(this.robot, this.obstacleDetector);
        }
    }
}
