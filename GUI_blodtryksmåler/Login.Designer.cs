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
            this.LogonBt.Location = new System.Drawing.Point(75, 199);
            this.LogonBt.Name = "LogonBt";
            this.LogonBt.Size = new System.Drawing.Size(132, 23);
            this.LogonBt.TabIndex = 0;
            this.LogonBt.Text = "Log på Blodtryksmåler";
            this.LogonBt.UseVisualStyleBackColor = true;
            this.LogonBt.Click += new System.EventHandler(this.Logon_Click);
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(75, 34);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(100, 20);
            this.IdTb.TabIndex = 1;
            // 
            // PassTb
            // 
            this.PassTb.Location = new System.Drawing.Point(75, 98);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(100, 20);
            this.PassTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.LogonBt);
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