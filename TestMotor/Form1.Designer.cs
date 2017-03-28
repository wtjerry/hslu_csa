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
            this.motorCtrlView = new RobotView.MotorCtrlView();
            this.driveCtrlView = new RobotView.DriveCtrlView();
            this.SuspendLayout();
            // 
            // motorCtrlView
            // 
            this.motorCtrlView.Location = new System.Drawing.Point(3, 81);
            this.motorCtrlView.MotorCtrl = null;
            this.motorCtrlView.Name = "motorCtrlView";
            this.motorCtrlView.Size = new System.Drawing.Size(431, 258);
            this.motorCtrlView.TabIndex = 0;
            // 
            // driveCtrlView
            // 
            this.driveCtrlView.DriveCtrl = null;
            this.driveCtrlView.Location = new System.Drawing.Point(0, 0);
            this.driveCtrlView.Name = "driveCtrlView";
            this.driveCtrlView.Size = new System.Drawing.Size(274, 57);
            this.driveCtrlView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.motorCtrlView);
            this.Controls.Add(this.driveCtrlView);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MotorCtrlView motorCtrlView;
        private DriveCtrlView driveCtrlView;
    }
}

