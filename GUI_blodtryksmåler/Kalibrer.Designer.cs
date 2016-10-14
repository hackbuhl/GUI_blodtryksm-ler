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
            this.SuspendLayout();
            // 
            // Tryk1TB
            // 
            this.Tryk1TB.Location = new System.Drawing.Point(46, 47);
            this.Tryk1TB.Name = "Tryk1TB";
            this.Tryk1TB.Size = new System.Drawing.Size(100, 20);
            this.Tryk1TB.TabIndex = 0;
            // 
            // Tryk2TB
            // 
            this.Tryk2TB.Location = new System.Drawing.Point(106, 182);
            this.Tryk2TB.Name = "Tryk2TB";
            this.Tryk2TB.Size = new System.Drawing.Size(100, 20);
            this.Tryk2TB.TabIndex = 1;
            // 
            // Kalibrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}