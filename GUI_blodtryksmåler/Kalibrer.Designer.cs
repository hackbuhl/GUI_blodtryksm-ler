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
            this.Tryk1TB.Location = new System.Drawing.Point(22, 76);
            this.Tryk1TB.Name = "Tryk1TB";
            this.Tryk1TB.Size = new System.Drawing.Size(100, 20);
            this.Tryk1TB.TabIndex = 0;
            // 
            // Tryk2TB
            // 
            this.Tryk2TB.Location = new System.Drawing.Point(168, 76);
            this.Tryk2TB.Name = "Tryk2TB";
            this.Tryk2TB.Size = new System.Drawing.Size(100, 20);
            this.Tryk2TB.TabIndex = 1;
            // 
            // LogafBt
            // 
            this.LogafBt.Location = new System.Drawing.Point(197, 12);
            this.LogafBt.Name = "LogafBt";
            this.LogafBt.Size = new System.Drawing.Size(75, 23);
            this.LogafBt.TabIndex = 2;
            this.LogafBt.Text = "Log af";
            this.LogafBt.UseVisualStyleBackColor = true;
            this.LogafBt.Click += new System.EventHandler(this.LogafBt_Click);
            // 
            // Tryk1Bt
            // 
            this.Tryk1Bt.Location = new System.Drawing.Point(22, 114);
            this.Tryk1Bt.Name = "Tryk1Bt";
            this.Tryk1Bt.Size = new System.Drawing.Size(100, 23);
            this.Tryk1Bt.TabIndex = 3;
            this.Tryk1Bt.Text = "Indlæs tryk 1";
            this.Tryk1Bt.UseVisualStyleBackColor = true;
            this.Tryk1Bt.Click += new System.EventHandler(this.Tryk1Bt_Click);
            // 
            // Tryk2Bt
            // 
            this.Tryk2Bt.Enabled = false;
            this.Tryk2Bt.Location = new System.Drawing.Point(168, 114);
            this.Tryk2Bt.Name = "Tryk2Bt";
            this.Tryk2Bt.Size = new System.Drawing.Size(100, 23);
            this.Tryk2Bt.TabIndex = 4;
            this.Tryk2Bt.Text = "Indlæs tryk 2";
            this.Tryk2Bt.UseVisualStyleBackColor = true;
            this.Tryk2Bt.Click += new System.EventHandler(this.Tryk2Bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "mmHg i \r\nvæskesøjlen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "mmHg i \r\nvæskesøjlen:\r\n";
            // 
            // KaliBt
            // 
            this.KaliBt.Enabled = false;
            this.KaliBt.Location = new System.Drawing.Point(22, 154);
            this.KaliBt.Name = "KaliBt";
            this.KaliBt.Size = new System.Drawing.Size(246, 47);
            this.KaliBt.TabIndex = 7;
            this.KaliBt.Text = "Kalibrer";
            this.KaliBt.UseVisualStyleBackColor = true;
            this.KaliBt.Click += new System.EventHandler(this.KaliBt_Click);
            // 
            // nulBt
            // 
            this.nulBt.Location = new System.Drawing.Point(22, 222);
            this.nulBt.Name = "nulBt";
            this.nulBt.Size = new System.Drawing.Size(246, 23);
            this.nulBt.TabIndex = 8;
            this.nulBt.Text = "Nulstil";
            this.nulBt.UseVisualStyleBackColor = true;
            this.nulBt.Click += new System.EventHandler(this.nulBt_Click);
            // 
            // Kalibrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nulBt);
            this.Controls.Add(this.KaliBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tryk2Bt);
            this.Controls.Add(this.Tryk1Bt);
            this.Controls.Add(this.LogafBt);
            this.Controls.Add(this.Tryk2TB);
            this.Controls.Add(this.Tryk1TB);
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