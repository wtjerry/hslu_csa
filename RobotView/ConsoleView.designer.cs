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
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.switchView4);
            this.Controls.Add(this.switchView3);
            this.Controls.Add(this.switchView2);
            this.Controls.Add(this.switchView1);            
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(281, 73);
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
    }
}
