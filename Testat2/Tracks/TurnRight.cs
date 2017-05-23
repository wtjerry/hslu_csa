using RobotCtrl;

namespace Testat2.Tracks
{
    public class TurnRight : Track
    {
        private readonly float angle;

        public TurnRight(Robot robot, float angle) : base(robot)
        {
            this.angle = angle;
        }

        protected override void RunTrack()
        {
            this.Robot.Drive.RunTurn(this.angle, this.Speed, this.Acceleration);
        }
    }
}
