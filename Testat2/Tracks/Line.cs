using RobotCtrl;

namespace Testat2.Tracks
{
    public class Line : Track
    {
        private readonly float distance;

        public Line(Robot robot, float distance) : base(robot)
        {
            this.distance = distance;
        }

        protected override void RunTrack()
        {
            this.Robot.Drive.RunLine(this.distance, this.Speed, this.Acceleration);
        }
    }
}
