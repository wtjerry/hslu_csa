namespace RobotView
{
    partial class RunLineView
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
            this.negativeLengthRadioButton = new System.Windows.Forms.RadioButton();
            this.positiveLengthRadioButton = new System.Windows.Forms.RadioButton();
            this.lengthInMilimeterTextBox = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(327, 21);
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
            this.label4.Text = "RunLine";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.Text = "Length (+/- mm)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.negativeLengthRadioButton);
            this.panel1.Controls.Add(this.positiveLengthRadioButton);
            this.panel1.Location = new System.Drawing.Point(115, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 23);
            // 
            // negativeLengthRadioButton
            // 
            this.negativeLengthRadioButton.Location = new System.Drawing.Point(53, 2);
            this.negativeLengthRadioButton.Name = "negativeLengthRadioButton";
            this.negativeLengthRadioButton.Size = new System.Drawing.Size(36, 20);
            this.negativeLengthRadioButton.TabIndex = 25;
            this.negativeLengthRadioButton.Text = "-";
            // 
            // positiveLengthRadioButton
            // 
            this.positiveLengthRadioButton.Location = new System.Drawing.Point(11, 2);
            this.positiveLengthRadioButton.Name = "positiveLengthRadioButton";
            this.positiveLengthRadioButton.Size = new System.Drawing.Size(36, 20);
            this.positiveLengthRadioButton.TabIndex = 24;
            this.positiveLengthRadioButton.Text = "+";
            // 
            // lengthInMilimeterTextBox
            // 
            this.lengthInMilimeterTextBox.Location = new System.Drawing.Point(221, 17);
            this.lengthInMilimeterTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lengthInMilimeterTextBox.Name = "lengthInMilimeterTextBox";
            this.lengthInMilimeterTextBox.Size = new System.Drawing.Size(100, 24);
            this.lengthInMilimeterTextBox.TabIndex = 18;
            // 
            // RunLineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lengthInMilimeterTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startButton);
            this.Name = "RunLineView";
            this.Size = new System.Drawing.Size(404, 50);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton negativeLengthRadioButton;
        private System.Windows.Forms.RadioButton positiveLengthRadioButton;
        private System.Windows.Forms.NumericUpDown lengthInMilimeterTextBox;
    }
}
