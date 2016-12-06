namespace GUI_blodtryksmåler
{
    partial class Login
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
            this.LogonBt = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogonBt
            // 
            this.LogonBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogonBt.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.LogonBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogonBt.Location = new System.Drawing.Point(112, 269);
            this.LogonBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogonBt.Name = "LogonBt";
            this.LogonBt.Size = new System.Drawing.Size(198, 35);
            this.LogonBt.TabIndex = 0;
            this.LogonBt.Text = "Login";
            this.LogonBt.UseVisualStyleBackColor = false;
            this.LogonBt.Click += new System.EventHandler(this.Logon_Click);
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(112, 52);
            this.IdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(148, 26);
            this.IdTb.TabIndex = 1;
            // 
            // PassTb
            // 
            this.PassTb.Location = new System.Drawing.Point(112, 151);
            this.PassTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(148, 26);
            this.PassTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(112, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.LogonBt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogonBt;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.TextBox PassTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}