using RobotCtrl;

namespace Testat2.Tracks
{
    internal class ArcRight : Track
    {
        private readonly float angle;
        private readonly float radius;

        internal ArcRight(Robot robot, ObstacleDetector obstacleDetector, float angle, float radius) : base(robot, obstacleDetector)
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
