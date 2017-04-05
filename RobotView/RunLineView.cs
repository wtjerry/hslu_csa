using System;
using System.Windows.Forms;
using RobotCtrl;
using RobotView.Resources;

namespace RobotView
{
    public partial class RunLineView : UserControl
    {
        private float speed;
        private float acceleration;
        
        public Drive Drive { get; set; }

        public RunLineView()
        {
            InitializeComponent();
        }

        public void updateSpeed(float speed)
        {
            this.speed = speed;
        }

        public void updateAcceleration(float acceleration)
        {
            this.acceleration = acceleration;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var lengthInMeter = (float) this.lengthInMilimeterTextBox.Value / 1000;
            if (this.negativeLengthRadioButton.Checked)
            {
                lengthInMeter *= -1;
            }
            this.Drive.RunLine(lengthInMeter, this.speed, this.acceleration);
        }
    }
}