using RobotCtrl;

namespace Testat2.Tracks
{
    internal class TurnRight : Track
    {
        private readonly float angle;

        internal TurnRight(Robot robot, ObstacleDetector obstacleDetector, float angle) : base(robot, obstacleDetector)
        {
            this.angle = angle;
        }

        protected override void RunTrack()
        {
            this.Robot.Drive.RunTurn(this.angle, this.Speed, this.Acceleration);
        }
    }
}
