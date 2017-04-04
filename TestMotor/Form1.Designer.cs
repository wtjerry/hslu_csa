using RobotCtrl;
using RobotView;

namespace TestMotor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.driveCtrlView = new RobotView.DriveCtrlView();
            
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.motorCtrlLeftView = new RobotView.MotorCtrlView();
            this.motorCtrlRightView = new RobotView.MotorCtrlView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // driveCtrlView
            // 
            this.driveCtrlView.Location = new System.Drawing.Point(0, 0);
            this.driveCtrlView.Name = "driveCtrlView";
            this.driveCtrlView.Size = new System.Drawing.Size(274, 57);
            this.driveCtrlView.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 312);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.motorCtrlLeftView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(556, 283);
            this.tabPage1.Text = "Motor left";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.motorCtrlRightView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(556, 283);
            this.tabPage2.Text = "Motor right";
            // 
            // motorCtrlLeftView
            // 
            this.motorCtrlLeftView.Location = new System.Drawing.Point(0, 3);
            this.motorCtrlLeftView.Name = "motorCtrlLeftView";
            this.motorCtrlLeftView.Size = new System.Drawing.Size(431, 258);
            this.motorCtrlLeftView.TabIndex = 3;
            // 
            // motorCtrlRightView
            // 
            this.motorCtrlRightView.Location = new System.Drawing.Point(0, 3);
            this.motorCtrlRightView.Name = "motorCtrlRightView";
            this.motorCtrlRightView.Size = new System.Drawing.Size(431, 258);
            this.motorCtrlRightView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.driveCtrlView);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DriveCtrlView driveCtrlView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MotorCtrlView motorCtrlLeftView;
        private System.Windows.Forms.TabPage tabPage2;
        private MotorCtrlView motorCtrlRightView;
    }
}

