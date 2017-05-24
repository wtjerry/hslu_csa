using RobotCtrl;

namespace Testat2.Tracks
{
    internal class Line : Track
    {
        private readonly float distance;

        internal Line(Robot robot, ObstacleDetector obstacleDetector, float distance) : base(robot, obstacleDetector)
        {
            this.distance = distance;
        }

        protected override void RunTrack()
        {
            this.Robot.Drive.RunLine(this.distance, this.Speed, this.Acceleration);
        }
    }
}
