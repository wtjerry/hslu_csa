using System;
using System.Windows.Forms;
using RobotCtrl;
using RobotView.Resources;

namespace RobotView
{
    public partial class LedView : UserControl
    {
        private bool state;
        private Led led;

        public LedView()
        {
            InitializeComponent();
            this.State = false;
        }

        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                if (this.pictureBox.InvokeRequired)
                {
                    this.pictureBox.Invoke((Action)(() => this.SetImageAccordingToLedState(value)));
                }
            }
        }

        private void SetImageAccordingToLedState(bool isSwitchOn)
        {
            if (isSwitchOn)
            {
                this.pictureBox.Image = Resource.LedOn;
            }
            else
            {
                this.pictureBox.Image = Resource.LedOff;
            }
        }

        public Led Led
        {
            get { return this.led; }
            set
            {
                if (this.led != null)
                {
                    this.led.LedStateChanged -= this.LedOnLedStateChanged;
                }
                this.led = value;
                if (this.led != null)
                {
                    this.led.LedStateChanged += this.LedOnLedStateChanged;
                }
            }
        }

        private void LedOnLedStateChanged(object sender, LedEventArgs ledEventArgs)
        {
            this.State = ledEventArgs.LedEnabled;
        }
    }
}