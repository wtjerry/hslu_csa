using System.Windows.Forms;
using RobotCtrl;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.commonRunParameters.AccelerationChanged += (sender, args) => updateRunUserControlsWithNewAcceleration();
            this.commonRunParameters.SpeedChanged += (sender, args) => updateRunUserControlsWithNewSpeed();

            var drive = new Drive();
            this.runLineView.Drive = drive;
            this.runTurnView.Drive = drive;
            this.runArcView.Drive = drive;
        }

        private void updateRunUserControlsWithNewAcceleration()
        {
            var acceleration = this.commonRunParameters.Acceleration;
            this.runLineView.updateAcceleration(acceleration);
            this.runTurnView.updateAcceleration(acceleration);
            this.runArcView.updateAcceleration(acceleration);
        }

        private void updateRunUserControlsWithNewSpeed()
        {
            var speed = this.commonRunParameters.Speed;
            this.runLineView.updateSpeed(speed);
            this.runTurnView.updateSpeed(speed);
            this.runArcView.updateSpeed(speed);
        }
    }
}
