﻿namespace GUI_blodtryksmåler
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
            this.grænseBt.Location = new System.Drawing.Point(60, 205);
            this.grænseBt.Name = "grænseBt";
            this.grænseBt.Size = new System.Drawing.Size(165, 35);
            this.grænseBt.TabIndex = 0;
            this.grænseBt.Text = "Sæt grænseværdier";
            this.grænseBt.UseVisualStyleBackColor = true;
            this.grænseBt.Click += new System.EventHandler(this.grænseBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Systolisk blodtryk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diastolisk blodtryk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Øvre grænse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Øvre grænse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nedre grænse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nedre grænse:";
            // 
            // ØvSysTb
            // 
            this.ØvSysTb.Location = new System.Drawing.Point(159, 40);
            this.ØvSysTb.Name = "ØvSysTb";
            this.ØvSysTb.Size = new System.Drawing.Size(100, 20);
            this.ØvSysTb.TabIndex = 7;
            // 
            // NedSysTb
            // 
            this.NedSysTb.Location = new System.Drawing.Point(159, 64);
            this.NedSysTb.Name = "NedSysTb";
            this.NedSysTb.Size = new System.Drawing.Size(100, 20);
            this.NedSysTb.TabIndex = 8;
            // 
            // ØvDiaTb
            // 
            this.ØvDiaTb.Location = new System.Drawing.Point(159, 134);
            this.ØvDiaTb.Name = "ØvDiaTb";
            this.ØvDiaTb.Size = new System.Drawing.Size(100, 20);
            this.ØvDiaTb.TabIndex = 9;
            // 
            // NedDiaTb
            // 
            this.NedDiaTb.Location = new System.Drawing.Point(159, 157);
            this.NedDiaTb.Name = "NedDiaTb";
            this.NedDiaTb.Size = new System.Drawing.Size(100, 20);
            this.NedDiaTb.TabIndex = 10;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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

