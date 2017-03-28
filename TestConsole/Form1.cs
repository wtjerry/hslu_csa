using System.Windows.Forms;
using RobotCtrl;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RobotConsole robotorConsole = new RobotConsole();

            robotorConsole[Switches.Switch1].SwitchStateChanged += (sender, args) => robotorConsole[Leds.Led1].LedEnabled = args.SwitchEnabled;
            robotorConsole[Switches.Switch2].SwitchStateChanged += (sender, args) => robotorConsole[Leds.Led2].LedEnabled = args.SwitchEnabled;
            robotorConsole[Switches.Switch3].SwitchStateChanged += (sender, args) => robotorConsole[Leds.Led3].LedEnabled = args.SwitchEnabled;
            robotorConsole[Switches.Switch4].SwitchStateChanged += (sender, args) => robotorConsole[Leds.Led4].LedEnabled = args.SwitchEnabled;
            
            this.consoleView.RobotConsole = robotorConsole;
        }
    }
}
