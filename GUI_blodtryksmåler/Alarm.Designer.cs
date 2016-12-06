namespace GUI_blodtryksmåler
{
    partial class Alarm
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
            this.grænseBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ØvSysTb = new System.Windows.Forms.TextBox();
            this.NedSysTb = new System.Windows.Forms.TextBox();
            this.ØvDiaTb = new System.Windows.Forms.TextBox();
            this.NedDiaTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // grænseBt
            // 
            this.grænseBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grænseBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grænseBt.Location = new System.Drawing.Point(90, 315);
            this.grænseBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grænseBt.Name = "grænseBt";
            this.grænseBt.Size = new System.Drawing.Size(248, 54);
            this.grænseBt.TabIndex = 0;
            this.grænseBt.Text = "Sæt grænseværdier";
            this.grænseBt.UseVisualStyleBackColor = false;
            this.grænseBt.Click += new System.EventHandler(this.grænseBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Systolisk blodtryk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diastolisk blodtryk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Øvre grænse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(32, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Øvre grænse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(32, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nedre grænse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(32, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nedre grænse:";
            // 
            // ØvSysTb
            // 
            this.ØvSysTb.Location = new System.Drawing.Point(238, 62);
            this.ØvSysTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ØvSysTb.Name = "ØvSysTb";
            this.ØvSysTb.Size = new System.Drawing.Size(148, 26);
            this.ØvSysTb.TabIndex = 7;
            // 
            // NedSysTb
            // 
            this.NedSysTb.Location = new System.Drawing.Point(238, 98);
            this.NedSysTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NedSysTb.Name = "NedSysTb";
            this.NedSysTb.Size = new System.Drawing.Size(148, 26);
            this.NedSysTb.TabIndex = 8;
            // 
            // ØvDiaTb
            // 
            this.ØvDiaTb.Location = new System.Drawing.Point(238, 206);
            this.ØvDiaTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ØvDiaTb.Name = "ØvDiaTb";
            this.ØvDiaTb.Size = new System.Drawing.Size(148, 26);
            this.ØvDiaTb.TabIndex = 9;
            // 
            // NedDiaTb
            // 
            this.NedDiaTb.Location = new System.Drawing.Point(238, 242);
            this.NedDiaTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NedDiaTb.Name = "NedDiaTb";
            this.NedDiaTb.Size = new System.Drawing.Size(148, 26);
            this.NedDiaTb.TabIndex = 10;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.NedDiaTb);
            this.Controls.Add(this.ØvDiaTb);
            this.Controls.Add(this.NedSysTb);
            this.Controls.Add(this.ØvSysTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grænseBt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Alarm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grænseBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ØvSysTb;
        private System.Windows.Forms.TextBox NedSysTb;
        private System.Windows.Forms.TextBox ØvDiaTb;
        private System.Windows.Forms.TextBox NedDiaTb;
    }
}

