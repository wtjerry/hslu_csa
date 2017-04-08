namespace Testat
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
            this.startButton = new System.Windows.Forms.Button();
            this.positionButton = new System.Windows.Forms.Button();
            this.positionLlabel = new System.Windows.Forms.Label();
            this.radarLabel = new System.Windows.Forms.Label();
            this.radarButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.currentRadarLabel = new System.Windows.Forms.Label();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(71, 216);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 20);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // positionButton
            // 
            this.positionButton.Location = new System.Drawing.Point(27, 104);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(191, 20);
            this.positionButton.TabIndex = 1;
            this.positionButton.Text = "get current position";
            this.positionButton.Click += new System.EventHandler(this.positionButton_Click);
            // 
            // positionLlabel
            // 
            this.positionLlabel.BackColor = System.Drawing.Color.Yellow;
            this.positionLlabel.Location = new System.Drawing.Point(260, 104);
            this.positionLlabel.Name = "positionLlabel";
            this.positionLlabel.Size = new System.Drawing.Size(296, 19);
            // 
            // radarLabel
            // 
            this.radarLabel.BackColor = System.Drawing.Color.Red;
            this.radarLabel.Location = new System.Drawing.Point(260, 145);
            this.radarLabel.Name = "radarLabel";
            this.radarLabel.Size = new System.Drawing.Size(296, 19);
            // 
            // radarButton
            // 
            this.radarButton.Location = new System.Drawing.Point(27, 145);
            this.radarButton.Name = "radarButton";
            this.radarButton.Size = new System.Drawing.Size(191, 20);
            this.radarButton.TabIndex = 4;
            this.radarButton.Text = "get radar value";
            this.radarButton.Click += new System.EventHandler(this.radarButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.BackColor = System.Drawing.Color.Lime;
            this.progressLabel.Location = new System.Drawing.Point(227, 198);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(388, 51);
            // 
            // currentRadarLabel
            // 
            this.currentRadarLabel.BackColor = System.Drawing.Color.Red;
            this.currentRadarLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.currentRadarLabel.Location = new System.Drawing.Point(3, 258);
            this.currentRadarLabel.Name = "currentRadarLabel";
            this.currentRadarLabel.Size = new System.Drawing.Size(612, 44);
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.BackColor = System.Drawing.Color.Red;
            this.currentPositionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.currentPositionLabel.Location = new System.Drawing.Point(3, 317);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(612, 44);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.currentPositionLabel);
            this.Controls.Add(this.currentRadarLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.radarLabel);
            this.Controls.Add(this.radarButton);
            this.Controls.Add(this.positionLlabel);
            this.Controls.Add(this.positionButton);
            this.Controls.Add(this.startButton);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button positionButton;
        private System.Windows.Forms.Label positionLlabel;
        private System.Windows.Forms.Label radarLabel;
        private System.Windows.Forms.Button radarButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label currentRadarLabel;
        private System.Windows.Forms.Label currentPositionLabel;
    }
}

