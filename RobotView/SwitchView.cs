using System;
using System.Windows.Forms;
using RobotCtrl;
using RobotView.Resources;

namespace RobotView
{
    public partial class SwitchView : UserControl
    {
        private bool state;
        private Switch switchControl;

        public SwitchView()
        {
            InitializeComponent();
            this.state = false;
        }

        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                if (value)
                {
                    this.pictureBox.Image = Resource.SwitchOn;
                }
                else
                {
                    this.pictureBox.Image = Resource.SwitchOff;
                }
            }
        }

        public Switch SwitchControl
        {
            get { return this.switchControl; }
            set
            {
                this.switchControl = value;
                if (this.switchControl != null)
                {
                    this.switchControl.SwitchStateChanged += this.SwitchControlOnSwitchStateChanged;
                }
            }
        }

        private void SwitchControlOnSwitchStateChanged(object sender, SwitchEventArgs switchEventArgs)
        {
            this.State = switchEventArgs.SwitchEnabled;
        }
    }
}