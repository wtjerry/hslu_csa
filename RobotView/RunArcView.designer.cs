namespace RobotView
{
    partial class RunArcView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusInMilimeterTextBox = new System.Windows.Forms.NumericUpDown();
            this.angleInDegreesTextBox = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.negativeAngleRadioButton = new System.Windows.Forms.RadioButton();
            this.positiveAngleRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.turnRighRadioButton = new System.Windows.Forms.RadioButton();
            this.turnLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.Text = "RunArc";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.Text = "Radius (+ mm)";
            // 
            // radiusInMilimeterTextBox
            // 
            this.radiusInMilimeterTextBox.Location = new System.Drawing.Point(221, 45);
            this.radiusInMilimeterTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.radiusInMilimeterTextBox.Name = "radiusInMilimeterTextBox";
            this.radiusInMilimeterTextBox.Size = new System.Drawing.Size(100, 24);
            this.radiusInMilimeterTextBox.TabIndex = 18;
            // 
            // angleInDegreesTextBox
            // 
            this.angleInDegreesTextBox.Location = new System.Drawing.Point(221, 82);
            this.angleInDegreesTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.angleInDegreesTextBox.Name = "angleInDegreesTextBox";
            this.angleInDegreesTextBox.Size = new System.Drawing.Size(100, 24);
            this.angleInDegreesTextBox.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.negativeAngleRadioButton);
            this.panel2.Controls.Add(this.positiveAngleRadioButton);
            this.panel2.Location = new System.Drawing.Point(115, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 23);
            // 
            // negativeAngleRadioButton
            // 
            this.negativeAngleRadioButton.Location = new System.Drawing.Point(53, 2);
            this.negativeAngleRadioButton.Name = "negativeAngleRadioButton";
            this.negativeAngleRadioButton.Size = new System.Drawing.Size(36, 20);
            this.negativeAngleRadioButton.TabIndex = 25;
            this.negativeAngleRadioButton.Text = "-";
            // 
            // positiveAngleRadioButton
            // 
            this.positiveAngleRadioButton.Location = new System.Drawing.Point(11, 2);
            this.positiveAngleRadioButton.Name = "positiveAngleRadioButton";
            this.positiveAngleRadioButton.Size = new System.Drawing.Size(36, 20);
            this.positiveAngleRadioButton.TabIndex = 24;
            this.positiveAngleRadioButton.Text = "+";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.Text = "Angle (+/- mm)";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(327, 86);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(72, 20);
            this.startButton.TabIndex = 24;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.turnRighRadioButton);
            this.panel1.Controls.Add(this.turnLeftRadioButton);
            this.panel1.Location = new System.Drawing.Point(221, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 23);
            // 
            // turnRighRadioButton
            // 
            this.turnRighRadioButton.Location = new System.Drawing.Point(69, 1);
            this.turnRighRadioButton.Name = "turnRighRadioButton";
            this.turnRighRadioButton.Size = new System.Drawing.Size(62, 20);
            this.turnRighRadioButton.TabIndex = 25;
            this.turnRighRadioButton.Text = "Right";
            // 
            // turnLeftRadioButton
            // 
            this.turnLeftRadioButton.Checked = true;
            this.turnLeftRadioButton.Location = new System.Drawing.Point(11, 2);
            this.turnLeftRadioButton.Name = "turnLeftRadioButton";
            this.turnLeftRadioButton.Size = new System.Drawing.Size(49, 20);
            this.turnLeftRadioButton.TabIndex = 24;
            this.turnLeftRadioButton.Text = "Left";
            // 
            // RunArcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.angleInDegreesTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.radiusInMilimeterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "RunArcView";
            this.Size = new System.Drawing.Size(413, 121);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown radiusInMilimeterTextBox;
        private System.Windows.Forms.NumericUpDown angleInDegreesTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton negativeAngleRadioButton;
        private System.Windows.Forms.RadioButton positiveAngleRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton turnRighRadioButton;
        private System.Windows.Forms.RadioButton turnLeftRadioButton;
    }
}
