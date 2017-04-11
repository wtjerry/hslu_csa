using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RobotCtrl;

namespace Testat
{
    public partial class Form1 : Form
    {
        private readonly Robot robot;

        public Form1()
        {
            InitializeComponent();

            this.robot = new Robot();
            this.robot.RobotConsole[Switches.Switch1].SwitchStateChanged += (sender, args) => this.RunBoxDetection();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.RunBoxDetection();
        }

        private void RunBoxDetection()
        {
            var ledBlinking = new BlinkLEDs(this.robot);
            var ledBlinkingThread = new Thread(() => ledBlinking.Run());

            var detectBox = new DetectBox(this.robot, this.progressLabel, this.currentPositionLabel, ledBlinking);
            var detectBoxThread = new Thread(() => detectBox.Run());

            ledBlinkingThread.Start();
            detectBoxThread.Start();
        }

        private void positionButton_Click(object sender, EventArgs e)
        {
            var robotPosition = this.robot.Position;
            this.positionLlabel.Text = $"angle {robotPosition.Angle}, x {this.robot.Position.X}, y {this.robot.Position.Y}";
        }

        private void radarButton_Click(object sender, EventArgs e)
        {
            this.radarLabel.Text = this.robot.Radar.Distance.ToString(CultureInfo.InvariantCulture);
        }
    }
}
