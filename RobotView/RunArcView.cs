using System;
using System.Windows.Forms;
using RobotCtrl;
using RobotView.Resources;

namespace RobotView
{
    public partial class RunArcView : UserControl
    {
        private float speed;
        private float acceleration;
        
        public Drive Drive { get; set; }

        public RunArcView()
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
            var angleInDegrees = (float) this.angleInDegreesTextBox.Value;
            var radiusInMilimeter = (float) this.radiusInMilimeterTextBox.Value / 1000;
            if (this.negativeAngleRadioButton.Checked)
            {
                radiusInMilimeter *= -1;
            }

            if (this.turnLeftRadioButton.Checked)
            {
                this.Drive.RunArcLeft(radiusInMilimeter, angleInDegrees, this.speed, this.acceleration);
            }
            else
            {
                this.Drive.RunArcRight(radiusInMilimeter, angleInDegrees, this.speed, this.acceleration);
            }
        }
    }
}