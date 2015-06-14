namespace Meteoryt
{
    partial class frmSetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPredkosc = new System.Windows.Forms.TextBox();
            this.TbTemperatura = new System.Windows.Forms.TextBox();
            this.TbMasa = new System.Windows.Forms.TextBox();
            this.TbOdleglosc = new System.Windows.Forms.TextBox();
            this.BtOk = new System.Windows.Forms.Button();
            this.BtExit = new System.Windows.Forms.Button();
            this.TbKatrotacji = new System.Windows.Forms.TextBox();
            this.TbP = new System.Windows.Forms.TextBox();
            this.TbY = new System.Windows.Forms.TextBox();
            this.TbX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preskość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odleglość";
            // 
            // TbPredkosc
            // 
            this.TbPredkosc.Location = new System.Drawing.Point(12, 50);
            this.TbPredkosc.Name = "TbPredkosc";
            this.TbPredkosc.Size = new System.Drawing.Size(100, 20);
            this.TbPredkosc.TabIndex = 4;
            this.TbPredkosc.Validating += new System.ComponentModel.CancelEventHandler(this.TbPredkosc_Validating);
            this.TbPredkosc.Validated += new System.EventHandler(this.TbPredkosc_Validated);
            // 
            // TbTemperatura
            // 
            this.TbTemperatura.Location = new System.Drawing.Point(15, 99);
            this.TbTemperatura.Name = "TbTemperatura";
            this.TbTemperatura.Size = new System.Drawing.Size(100, 20);
            this.TbTemperatura.TabIndex = 5;
            this.TbTemperatura.Validating += new System.ComponentModel.CancelEventHandler(this.TbTemperatura_Validating);
            this.TbTemperatura.Validated += new System.EventHandler(this.TbTemperatura_Validated);
            // 
            // TbMasa
            // 
            this.TbMasa.Location = new System.Drawing.Point(15, 150);
            this.TbMasa.Name = "TbMasa";
            this.TbMasa.Size = new System.Drawing.Size(100, 20);
            this.TbMasa.TabIndex = 6;
            this.TbMasa.Validating += new System.ComponentModel.CancelEventHandler(this.TbMasa_Validating);
            this.TbMasa.Validated += new System.EventHandler(this.TbMasa_Validated);
            // 
            // TbOdleglosc
            // 
            this.TbOdleglosc.Location = new System.Drawing.Point(15, 198);
            this.TbOdleglosc.Name = "TbOdleglosc";
            this.TbOdleglosc.Size = new System.Drawing.Size(100, 20);
            this.TbOdleglosc.TabIndex = 7;
            this.TbOdleglosc.Validating += new System.ComponentModel.CancelEventHandler(this.TbOdleglosc_Validating);
            this.TbOdleglosc.Validated += new System.EventHandler(this.TbOdleglosc_Validated);
            // 
            // BtOk
            // 
            this.BtOk.Location = new System.Drawing.Point(12, 282);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 8;
            this.BtOk.Text = "Ok";
            this.BtOk.UseVisualStyleBackColor = true;
            this.BtOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // BtExit
            // 
            this.BtExit.Location = new System.Drawing.Point(142, 282);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(75, 23);
            this.BtExit.TabIndex = 9;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // TbKatrotacji
            // 
            this.TbKatrotacji.Location = new System.Drawing.Point(280, 50);
            this.TbKatrotacji.Name = "TbKatrotacji";
            this.TbKatrotacji.Size = new System.Drawing.Size(100, 20);
            this.TbKatrotacji.TabIndex = 10;
            this.TbKatrotacji.Validating += new System.ComponentModel.CancelEventHandler(this.TbKatrotacji_Validating);
            this.TbKatrotacji.Validated += new System.EventHandler(this.TbKatrotacji_Validated);
            // 
            // TbP
            // 
            this.TbP.Location = new System.Drawing.Point(151, 150);
            this.TbP.Name = "TbP";
            this.TbP.Size = new System.Drawing.Size(100, 20);
            this.TbP.TabIndex = 12;
            this.TbP.Validating += new System.ComponentModel.CancelEventHandler(this.TbWysokość_Validating);
            this.TbP.Validated += new System.EventHandler(this.TbWysokość_Validated);
            // 
            // TbY
            // 
            this.TbY.Location = new System.Drawing.Point(151, 99);
            this.TbY.Name = "TbY";
            this.TbY.Size = new System.Drawing.Size(100, 20);
            this.TbY.TabIndex = 13;
            this.TbY.Validating += new System.ComponentModel.CancelEventHandler(this.TbY_Validating);
            this.TbY.Validated += new System.EventHandler(this.TbY_Validated);
            // 
            // TbX
            // 
            this.TbX.Location = new System.Drawing.Point(151, 50);
            this.TbX.Name = "TbX";
            this.TbX.Size = new System.Drawing.Size(100, 20);
            this.TbX.TabIndex = 14;
            this.TbX.Validating += new System.ComponentModel.CancelEventHandler(this.TbX_Validating);
            this.TbX.Validated += new System.EventHandler(this.TbX_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kąt rotacji";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "P";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "X";
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 332);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbX);
            this.Controls.Add(this.TbY);
            this.Controls.Add(this.TbP);
            this.Controls.Add(this.TbKatrotacji);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.BtOk);
            this.Controls.Add(this.TbOdleglosc);
            this.Controls.Add(this.TbMasa);
            this.Controls.Add(this.TbTemperatura);
            this.Controls.Add(this.TbPredkosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(405, 370);
            this.MinimumSize = new System.Drawing.Size(405, 370);
            this.Name = "frmSetup";
            this.Text = "Ustawienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbPredkosc;
        private System.Windows.Forms.TextBox TbTemperatura;
        private System.Windows.Forms.TextBox TbMasa;
        private System.Windows.Forms.TextBox TbOdleglosc;
        private System.Windows.Forms.Button BtOk;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.TextBox TbKatrotacji;
        private System.Windows.Forms.TextBox TbP;
        private System.Windows.Forms.TextBox TbY;
        private System.Windows.Forms.TextBox TbX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}