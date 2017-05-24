using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace Testat2.Tracks
{
    internal class NullTrack : Track
    {
        public NullTrack(Robot robot) : base(robot)
        {
        }

        protected override void RunTrack()
        {
        }
    }
}
