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
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Name = "ConsoleView";
            this.ResumeLayout(false);

        }

        #endregion

        private LedView ledView1;
        private LedView ledView2;
        private LedView ledView3;
        private LedView ledView4;
    }
}
