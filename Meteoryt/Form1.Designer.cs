namespace Meteoryt
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtDane = new System.Windows.Forms.Button();
            this.BtStart = new System.Windows.Forms.Button();
            this.BtStop = new System.Windows.Forms.Button();
            this.BtExit = new System.Windows.Forms.Button();
            this.class11 = new Meteoryt.Class1();
            this.SuspendLayout();
            // 
            // BtDane
            // 
            this.BtDane.Location = new System.Drawing.Point(12, 12);
            this.BtDane.Name = "BtDane";
            this.BtDane.Size = new System.Drawing.Size(75, 23);
            this.BtDane.TabIndex = 0;
            this.BtDane.Text = "Dane";
            this.BtDane.UseVisualStyleBackColor = true;
            this.BtDane.Click += new System.EventHandler(this.BtDane_Click);
            // 
            // BtStart
            // 
            this.BtStart.Location = new System.Drawing.Point(138, 12);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(75, 23);
            this.BtStart.TabIndex = 1;
            this.BtStart.Text = "Start";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // BtStop
            // 
            this.BtStop.Location = new System.Drawing.Point(219, 12);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(75, 23);
            this.BtStop.TabIndex = 2;
            this.BtStop.Text = "Stop";
            this.BtStop.UseVisualStyleBackColor = true;
            // 
            // BtExit
            // 
            this.BtExit.Location = new System.Drawing.Point(1012, 12);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(75, 23);
            this.BtExit.TabIndex = 3;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // class11
            // 
            this.class11.Location = new System.Drawing.Point(12, 41);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(1075, 635);
            this.class11.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 688);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.BtStop);
            this.Controls.Add(this.BtStart);
            this.Controls.Add(this.BtDane);
            this.Name = "Form1";
            this.Text = "Symulacja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtDane;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Button BtExit;
        private Class1 class11;
    }
}

