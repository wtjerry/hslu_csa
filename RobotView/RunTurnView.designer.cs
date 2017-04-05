namespace RobotView
{
    partial class RunTurnView
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
            this.startButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.negativeAngleRadioButton = new System.Windows.Forms.RadioButton();
            this.positiveAngleRadioButton = new System.Windows.Forms.RadioButton();
            this.angleInDegreesTextBox = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(345, 21);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(72, 20);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.Text = "RunTurn";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.Text = "Angle(+/- degrees)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.negativeAngleRadioButton);
            this.panel1.Controls.Add(this.positiveAngleRadioButton);
            this.panel1.Location = new System.Drawing.Point(133, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 23);
            // 
            // negativeAngleRadioButton
            // 
            this.negativeAngleRadioButton.Location = new System.Drawing.Point(53, 2);
            this.negativeAngleRadioButton.Name = "negativeAngleRadioButton";
            this.negativeAngleRadioButton.Size = new System.Drawing.Size(36, 20);
            this.negativeAngleRadioButton.TabIndex = 25;
            this.negativeAngleRadioButton.TabStop = false;
            this.negativeAngleRadioButton.Text = "-";
            // 
            // positiveAngleRadioButton
            // 
            this.positiveAngleRadioButton.Checked = true;
            this.positiveAngleRadioButton.Location = new System.Drawing.Point(11, 2);
            this.positiveAngleRadioButton.Name = "positiveAngleRadioButton";
            this.positiveAngleRadioButton.Size = new System.Drawing.Size(36, 20);
            this.positiveAngleRadioButton.TabIndex = 24;
            this.positiveAngleRadioButton.Text = "+";
            // 
            // angleInDegreesTextBox
            // 
            this.angleInDegreesTextBox.Location = new System.Drawing.Point(239, 17);
            this.angleInDegreesTextBox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleInDegreesTextBox.Name = "angleInDegreesTextBox";
            this.angleInDegreesTextBox.Size = new System.Drawing.Size(100, 24);
            this.angleInDegreesTextBox.TabIndex = 18;
            // 
            // RunTurnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.angleInDegreesTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startButton);
            this.Name = "RunTurnView";
            this.Size = new System.Drawing.Size(430, 51);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton negativeAngleRadioButton;
        private System.Windows.Forms.RadioButton positiveAngleRadioButton;
        private System.Windows.Forms.NumericUpDown angleInDegreesTextBox;
    }
}
