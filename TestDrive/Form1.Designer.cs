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
            this.runLineView = new RobotView.RunLineView();
            this.runTurnView = new RobotView.RunTurnView();
            this.SuspendLayout();
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(3, 3);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(292, 289);
            this.driveView.TabIndex = 0;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(3, 298);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(360, 84);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 0;
            // 
            // runLineView
            // 
            this.runLineView.Drive = null;
            this.runLineView.Location = new System.Drawing.Point(3, 388);
            this.runLineView.Name = "runLineView";
            this.runLineView.Size = new System.Drawing.Size(404, 50);
            this.runLineView.TabIndex = 1;
            // 
            // runTurnView
            // 
            this.runTurnView.Drive = null;
            this.runTurnView.Location = new System.Drawing.Point(3, 444);
            this.runTurnView.Name = "runTurnView";
            this.runTurnView.Size = new System.Drawing.Size(430, 51);
            this.runTurnView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(671, 566);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.commonRunParameters);
            this.Controls.Add(this.runLineView);
            this.Controls.Add(this.runTurnView);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DriveView driveView;
        private CommonRunParameters commonRunParameters;
        private RunLineView runLineView;
        private RunTurnView runTurnView;
    }
}

