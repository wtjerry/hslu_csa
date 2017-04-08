using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using RobotCtrl;

namespace Testat
{
    public class BlinkLEDs
    {
        private readonly Robot robot;
        private bool continueBlinking;

        public BlinkLEDs(Robot robot)
        {
            this.robot = robot;
            this.continueBlinking = true;
        }

        public void Run()
        {
            while (this.continueBlinking)
            {
                TurnLEDsOn();
                Thread.Sleep(100);
                TurnLEDsOff();
                Thread.Sleep(100);
            }
        }

        public void Stop()
        {
            this.TurnLEDsOff();
            this.continueBlinking = false;
        }

        private void TurnLEDsOn()
        {
            this.robot.RobotConsole[Leds.Led1].LedEnabled = true;
            this.robot.RobotConsole[Leds.Led2].LedEnabled = true;
            this.robot.RobotConsole[Leds.Led3].LedEnabled = true;
            this.robot.RobotConsole[Leds.Led4].LedEnabled = true;
        }

        private void TurnLEDsOff()
        {
            this.robot.RobotConsole[Leds.Led1].LedEnabled = false;
            this.robot.RobotConsole[Leds.Led2].LedEnabled = false;
            this.robot.RobotConsole[Leds.Led3].LedEnabled = false;
            this.robot.RobotConsole[Leds.Led4].LedEnabled = false;
        }
    }
}
