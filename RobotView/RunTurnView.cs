using System;
using System.Windows.Forms;
using RobotCtrl;
using RobotView.Resources;

namespace RobotView
{
    public partial class RunTurnView : UserControl
    {
        private float speed;
        private float acceleration;
        
        public Drive Drive { get; set; }

        public RunTurnView()
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
            if (this.negativeAngleRadioButton.Checked)
            {
                angleInDegrees *= -1;
            }
            this.Drive.RunTurn(angleInDegrees, this.speed, this.acceleration);
        }
    }
}