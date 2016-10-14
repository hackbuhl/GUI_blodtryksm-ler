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
            this.Logon = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Logon
            // 
            this.Logon.Location = new System.Drawing.Point(75, 199);
            this.Logon.Name = "Logon";
            this.Logon.Size = new System.Drawing.Size(132, 23);
            this.Logon.TabIndex = 0;
            this.Logon.Text = "Log på Blodtryksmåler";
            this.Logon.UseVisualStyleBackColor = true;
            this.Logon.Click += new System.EventHandler(this.Logon_Click);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(75, 34);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(100, 20);
            this.IdBox.TabIndex = 1;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(75, 98);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.Logon);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logon;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PassBox;
    }
}