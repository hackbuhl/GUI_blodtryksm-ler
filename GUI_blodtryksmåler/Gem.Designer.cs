namespace GUI_blodtryksmåler
{
    partial class Gem
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
            this.CPRTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteTb = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPRTb
            // 
            this.CPRTb.Location = new System.Drawing.Point(38, 75);
            this.CPRTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPRTb.Name = "CPRTb";
            this.CPRTb.Size = new System.Drawing.Size(368, 26);
            this.CPRTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patientens CPR-nummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Noter til måling:";
            // 
            // NoteTb
            // 
            this.NoteTb.Location = new System.Drawing.Point(38, 160);
            this.NoteTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoteTb.Name = "NoteTb";
            this.NoteTb.Size = new System.Drawing.Size(368, 150);
            this.NoteTb.TabIndex = 3;
            this.NoteTb.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(109, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(151, 54);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Gem";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Gem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.NoteTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPRTb);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gem";
            this.Text = "Gem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CPRTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NoteTb;
        private System.Windows.Forms.Button saveButton;
    }
}