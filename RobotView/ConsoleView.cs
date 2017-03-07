using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        private RobotConsole robotConsole;

        public RobotConsole RobotConsole
        {
            get { return this.robotConsole; }
            set
            {
                this.robotConsole = value;
                if (this.robotConsole != null)
                {
                    this.ledView1.Led = this.robotConsole[Leds.Led1];
                    this.ledView2.Led = this.robotConsole[Leds.Led2];
                    this.ledView3.Led = this.robotConsole[Leds.Led3];
                    this.ledView4.Led = this.robotConsole[Leds.Led4];
                    this.switchView1.SwitchControl = this.robotConsole[Switches.Switch1];
                    this.switchView2.SwitchControl = this.robotConsole[Switches.Switch2];
                    this.switchView3.SwitchControl = this.robotConsole[Switches.Switch3];
                    this.switchView4.SwitchControl = this.robotConsole[Switches.Switch4];
                }
            }
        }

        public ConsoleView()
        {
            InitializeComponent();
        }
    }
}