namespace Meteoryt
{
    partial class Form2
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
            // 
            // TbTemperatura
            // 
            this.TbTemperatura.Location = new System.Drawing.Point(15, 99);
            this.TbTemperatura.Name = "TbTemperatura";
            this.TbTemperatura.Size = new System.Drawing.Size(100, 20);
            this.TbTemperatura.TabIndex = 5;
            // 
            // TbMasa
            // 
            this.TbMasa.Location = new System.Drawing.Point(15, 150);
            this.TbMasa.Name = "TbMasa";
            this.TbMasa.Size = new System.Drawing.Size(100, 20);
            this.TbMasa.TabIndex = 6;
            // 
            // TbOdleglosc
            // 
            this.TbOdleglosc.Location = new System.Drawing.Point(15, 198);
            this.TbOdleglosc.Name = "TbOdleglosc";
            this.TbOdleglosc.Size = new System.Drawing.Size(100, 20);
            this.TbOdleglosc.TabIndex = 7;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 306);
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
            this.Name = "Form2";
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
    }
}