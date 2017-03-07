namespace RobotView
{
    partial class ConsoleView
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
            this.ledView1 = new RobotView.LedView();
            this.ledView2 = new RobotView.LedView();
            this.ledView3 = new RobotView.LedView();
            this.ledView4 = new RobotView.LedView();
            this.switchView1 = new RobotView.SwitchView();
            this.switchView2 = new RobotView.SwitchView();
            this.switchView3 = new RobotView.SwitchView();
            this.switchView4 = new RobotView.SwitchView();
            this.led0Label = new System.Windows.Forms.Label();
            this.led1Label = new System.Windows.Forms.Label();
            this.led2Label = new System.Windows.Forms.Label();
            this.led3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ledView1
            // 
            this.ledView1.Led = null;
            this.ledView1.Location = new System.Drawing.Point(3, 3);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 20);
            this.ledView1.State = false;
            this.ledView1.TabIndex = 0;
            // 
            // ledView2
            // 
            this.ledView2.Led = null;
            this.ledView2.Location = new System.Drawing.Point(29, 3);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 20);
            this.ledView2.State = false;
            this.ledView2.TabIndex = 1;
            // 
            // ledView3
            // 
            this.ledView3.Led = null;
            this.ledView3.Location = new System.Drawing.Point(55, 3);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 20);
            this.ledView3.State = false;
            this.ledView3.TabIndex = 2;
            // 
            // ledView4
            // 
            this.ledView4.Led = null;
            this.ledView4.Location = new System.Drawing.Point(81, 3);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(20, 20);
            this.ledView4.State = false;
            this.ledView4.TabIndex = 3;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(107, 3);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(20, 40);
            this.switchView1.State = false;
            this.switchView1.SwitchControl = null;
            this.switchView1.TabIndex = 4;
            // 
            // switchView2
            // 
            this.switchView2.Location = new System.Drawing.Point(133, 3);
            this.switchView2.Name = "switchView2";
            this.switchView2.Size = new System.Drawing.Size(20, 40);
            this.switchView2.State = false;
            this.switchView2.SwitchControl = null;
            this.switchView2.TabIndex = 5;
            // 
            // switchView3
            // 
            this.switchView3.Location = new System.Drawing.Point(159, 3);
            this.switchView3.Name = "switchView3";
            this.switchView3.Size = new System.Drawing.Size(20, 40);
            this.switchView3.State = false;
            this.switchView3.SwitchControl = null;
            this.switchView3.TabIndex = 6;
            // 
            // switchView4
            // 
            this.switchView4.Location = new System.Drawing.Point(185, 3);
            this.switchView4.Name = "switchView4";
            this.switchView4.Size = new System.Drawing.Size(20, 40);
            this.switchView4.State = false;
            this.switchView4.SwitchControl = null;
            this.switchView4.TabIndex = 7;
            // 
            // led0Label
            // 
            this.led0Label.ForeColor = System.Drawing.Color.White;
            this.led0Label.Location = new System.Drawing.Point(3, 28);
            this.led0Label.Name = "led0Label";
            this.led0Label.Size = new System.Drawing.Size(20, 15);
            this.led0Label.Text = "0";
            this.led0Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // led1Label
            // 
            this.led1Label.ForeColor = System.Drawing.Color.White;
            this.led1Label.Location = new System.Drawing.Point(29, 28);
            this.led1Label.Name = "led1Label";
            this.led1Label.Size = new System.Drawing.Size(20, 15);
            this.led1Label.Text = "1";
            this.led1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // led2Label
            // 
            this.led2Label.ForeColor = System.Drawing.Color.White;
            this.led2Label.Location = new System.Drawing.Point(55, 28);
            this.led2Label.Name = "led2Label";
            this.led2Label.Size = new System.Drawing.Size(20, 15);
            this.led2Label.Text = "2";
            this.led2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // led3Label
            // 
            this.led3Label.ForeColor = System.Drawing.Color.White;
            this.led3Label.Location = new System.Drawing.Point(81, 28);
            this.led3Label.Name = "led3Label";
            this.led3Label.Size = new System.Drawing.Size(20, 15);
            this.led3Label.Text = "3";
            this.led3Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.led3Label);
            this.Controls.Add(this.led2Label);
            this.Controls.Add(this.led1Label);
            this.Controls.Add(this.led0Label);
            this.Controls.Add(this.switchView4);
            this.Controls.Add(this.switchView3);
            this.Controls.Add(this.switchView2);
            this.Controls.Add(this.switchView1);
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(216, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private LedView ledView1;
        private LedView ledView2;
        private LedView ledView3;
        private LedView ledView4;

        private SwitchView switchView1;
        private SwitchView switchView2;
        private SwitchView switchView3;
        private SwitchView switchView4;
        private System.Windows.Forms.Label led0Label;
        private System.Windows.Forms.Label led1Label;
        private System.Windows.Forms.Label led2Label;
        private System.Windows.Forms.Label led3Label;
    }
}
