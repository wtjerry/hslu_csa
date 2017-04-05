using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.commonRunParameters.AccelerationChanged +=
                (sender, args) => this.runLineView.updateAcceleration(this.commonRunParameters.Acceleration);
            this.commonRunParameters.SpeedChanged +=
                (sender, args) => this.runLineView.updateSpeed(this.commonRunParameters.Speed);
            this.runLineView.Drive = new Drive();
        }
    }
}
