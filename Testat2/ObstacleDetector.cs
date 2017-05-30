using System.Threading;
using RobotCtrl;

namespace Testat2
{
    internal class ObstacleDetector
    {
        private readonly Robot robot;

        private const float MinDistanceForSomethingToBeBlockingThePath = 0.6f;

        internal ObstacleDetector(Robot robot)
        {
            this.robot = robot;
        }

        internal bool IsAnObstacleBlockingThePath()
        {
            var firstDistanceMeasurement = this.robot.Radar.Distance;
            Thread.Sleep(100);
            var secondDistanceMeasurement = this.robot.Radar.Distance;

            if (firstDistanceMeasurement < MinDistanceForSomethingToBeBlockingThePath
                && secondDistanceMeasurement < MinDistanceForSomethingToBeBlockingThePath)
            {
                return true;
            }

            return false;
        }
    }
}
