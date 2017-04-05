using RobotView;

namespace TestDrive
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
            this.driveView = new RobotView.DriveView();
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.SuspendLayout();
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(3, 90);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(292, 289);
            this.driveView.TabIndex = 0;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(3, 0);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(360, 84);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.commonRunParameters);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DriveView driveView;
        private CommonRunParameters commonRunParameters;
    }
}

