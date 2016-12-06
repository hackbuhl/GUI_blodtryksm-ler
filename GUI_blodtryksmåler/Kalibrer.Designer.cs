namespace GUI_blodtryksmåler
{
    partial class Kalibrer
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
            this.Tryk1TB = new System.Windows.Forms.TextBox();
            this.Tryk2TB = new System.Windows.Forms.TextBox();
            this.LogafBt = new System.Windows.Forms.Button();
            this.Tryk1Bt = new System.Windows.Forms.Button();
            this.Tryk2Bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KaliBt = new System.Windows.Forms.Button();
            this.nulBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tryk1TB
            // 
            this.Tryk1TB.Location = new System.Drawing.Point(33, 117);
            this.Tryk1TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tryk1TB.Name = "Tryk1TB";
            this.Tryk1TB.Size = new System.Drawing.Size(148, 26);
            this.Tryk1TB.TabIndex = 0;
            // 
            // Tryk2TB
            // 
            this.Tryk2TB.Enabled = false;
            this.Tryk2TB.Location = new System.Drawing.Point(252, 117);
            this.Tryk2TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tryk2TB.Name = "Tryk2TB";
            this.Tryk2TB.Size = new System.Drawing.Size(148, 26);
            this.Tryk2TB.TabIndex = 1;
            // 
            // LogafBt
            // 
            this.LogafBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogafBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogafBt.Location = new System.Drawing.Point(296, 18);
            this.LogafBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogafBt.Name = "LogafBt";
            this.LogafBt.Size = new System.Drawing.Size(112, 35);
            this.LogafBt.TabIndex = 2;
            this.LogafBt.Text = "Log af";
            this.LogafBt.UseVisualStyleBackColor = false;
            this.LogafBt.Click += new System.EventHandler(this.LogafBt_Click);
            // 
            // Tryk1Bt
            // 
            this.Tryk1Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tryk1Bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tryk1Bt.Location = new System.Drawing.Point(33, 175);
            this.Tryk1Bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tryk1Bt.Name = "Tryk1Bt";
            this.Tryk1Bt.Size = new System.Drawing.Size(150, 35);
            this.Tryk1Bt.TabIndex = 3;
            this.Tryk1Bt.Text = "Indlæs tryk 1";
            this.Tryk1Bt.UseVisualStyleBackColor = false;
            this.Tryk1Bt.Click += new System.EventHandler(this.Tryk1Bt_Click);
            // 
            // Tryk2Bt
            // 
            this.Tryk2Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tryk2Bt.Enabled = false;
            this.Tryk2Bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tryk2Bt.Location = new System.Drawing.Point(252, 175);
            this.Tryk2Bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tryk2Bt.Name = "Tryk2Bt";
            this.Tryk2Bt.Size = new System.Drawing.Size(150, 35);
            this.Tryk2Bt.TabIndex = 4;
            this.Tryk2Bt.Text = "Indlæs tryk 2";
            this.Tryk2Bt.UseVisualStyleBackColor = false;
            this.Tryk2Bt.Click += new System.EventHandler(this.Tryk2Bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "mmHg i \r\nvæskesøjlen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(248, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "mmHg i \r\nvæskesøjlen:\r\n";
            // 
            // KaliBt
            // 
            this.KaliBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KaliBt.Enabled = false;
            this.KaliBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KaliBt.Location = new System.Drawing.Point(33, 278);
            this.KaliBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KaliBt.Name = "KaliBt";
            this.KaliBt.Size = new System.Drawing.Size(369, 72);
            this.KaliBt.TabIndex = 7;
            this.KaliBt.Text = "Kalibrer";
            this.KaliBt.UseVisualStyleBackColor = false;
            this.KaliBt.Click += new System.EventHandler(this.KaliBt_Click);
            // 
            // nulBt
            // 
            this.nulBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nulBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nulBt.Location = new System.Drawing.Point(33, 383);
            this.nulBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nulBt.Name = "nulBt";
            this.nulBt.Size = new System.Drawing.Size(369, 35);
            this.nulBt.TabIndex = 8;
            this.nulBt.Text = "Nulstil";
            this.nulBt.UseVisualStyleBackColor = false;
            this.nulBt.Click += new System.EventHandler(this.nulBt_Click);
            // 
            // Kalibrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 440);
            this.Controls.Add(this.nulBt);
            this.Controls.Add(this.KaliBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tryk2Bt);
            this.Controls.Add(this.Tryk1Bt);
            this.Controls.Add(this.LogafBt);
            this.Controls.Add(this.Tryk2TB);
            this.Controls.Add(this.Tryk1TB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kalibrer";
            this.Text = "Kalibrer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tryk1TB;
        private System.Windows.Forms.TextBox Tryk2TB;
        private System.Windows.Forms.Button LogafBt;
        private System.Windows.Forms.Button Tryk1Bt;
        private System.Windows.Forms.Button Tryk2Bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KaliBt;
        private System.Windows.Forms.Button nulBt;
    }
}