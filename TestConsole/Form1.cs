using System.Windows.Forms;
using RobotCtrl;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.consoleView.RobotConsole = new RobotConsole();
        }
    }
}
