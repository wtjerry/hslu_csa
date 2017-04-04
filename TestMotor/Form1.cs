using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestMotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.driveCtrlView.DriveCtrl = new DriveCtrl(Constants.IODriveCtrl);
            this.motorCtrlLeftView.MotorCtrl = new MotorCtrl(Constants.IOMotorCtrlLeft);
            this.motorCtrlRightView.MotorCtrl = new MotorCtrl(Constants.IOMotorCtrlRight);
        }
    }
}
