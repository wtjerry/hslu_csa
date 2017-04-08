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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var detectBox = new DetectBox(this.robot, this.currentRadarLabel, this.progressLabel, this.currentPositionLabel);
            new Thread(() => detectBox.Run()).Start();
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
