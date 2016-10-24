namespace GUI_blodtryksmåler
{
    partial class Måling
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nulpunktBt = new System.Windows.Forms.Button();
            this.MålingBt = new System.Windows.Forms.Button();
            this.AlarmBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.nulBt = new System.Windows.Forms.Button();
            this.LogoutBt = new System.Windows.Forms.Button();
            this.SysLb = new System.Windows.Forms.Label();
            this.DiaLb = new System.Windows.Forms.Label();
            this.PulsLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DigitalfilterChB = new System.Windows.Forms.CheckBox();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // nulpunktBt
            // 
            this.nulpunktBt.Location = new System.Drawing.Point(19, 388);
            this.nulpunktBt.Name = "nulpunktBt";
            this.nulpunktBt.Size = new System.Drawing.Size(110, 71);
            this.nulpunktBt.TabIndex = 0;
            this.nulpunktBt.Text = "Foretag nulpunktsjustering";
            this.nulpunktBt.UseVisualStyleBackColor = true;
            // 
            // MålingBt
            // 
            this.MålingBt.Location = new System.Drawing.Point(135, 388);
            this.MålingBt.Name = "MålingBt";
            this.MålingBt.Size = new System.Drawing.Size(109, 71);
            this.MålingBt.TabIndex = 1;
            this.MålingBt.Text = "Start Måling";
            this.MålingBt.UseVisualStyleBackColor = true;
            // 
            // AlarmBt
            // 
            this.AlarmBt.Location = new System.Drawing.Point(357, 388);
            this.AlarmBt.Name = "AlarmBt";
            this.AlarmBt.Size = new System.Drawing.Size(153, 35);
            this.AlarmBt.TabIndex = 2;
            this.AlarmBt.Text = "Opsæt Alarm";
            this.AlarmBt.UseVisualStyleBackColor = true;
            // 
            // SaveBt
            // 
            this.SaveBt.Location = new System.Drawing.Point(886, 388);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(93, 71);
            this.SaveBt.TabIndex = 3;
            this.SaveBt.Text = "Gem Måling";
            this.SaveBt.UseVisualStyleBackColor = true;
            // 
            // nulBt
            // 
            this.nulBt.Location = new System.Drawing.Point(760, 388);
            this.nulBt.Name = "nulBt";
            this.nulBt.Size = new System.Drawing.Size(120, 71);
            this.nulBt.TabIndex = 4;
            this.nulBt.Text = "Nulstil";
            this.nulBt.UseVisualStyleBackColor = true;
            // 
            // LogoutBt
            // 
            this.LogoutBt.Location = new System.Drawing.Point(914, 13);
            this.LogoutBt.Name = "LogoutBt";
            this.LogoutBt.Size = new System.Drawing.Size(75, 31);
            this.LogoutBt.TabIndex = 5;
            this.LogoutBt.Text = "Log af";
            this.LogoutBt.UseVisualStyleBackColor = true;
            // 
            // SysLb
            // 
            this.SysLb.AutoSize = true;
            this.SysLb.Location = new System.Drawing.Point(51, 50);
            this.SysLb.Name = "SysLb";
            this.SysLb.Size = new System.Drawing.Size(36, 13);
            this.SysLb.TabIndex = 6;
            this.SysLb.Text = "SysLb";
            // 
            // DiaLb
            // 
            this.DiaLb.AutoSize = true;
            this.DiaLb.Location = new System.Drawing.Point(100, 114);
            this.DiaLb.Name = "DiaLb";
            this.DiaLb.Size = new System.Drawing.Size(35, 13);
            this.DiaLb.TabIndex = 7;
            this.DiaLb.Text = "label2";
            // 
            // PulsLb
            // 
            this.PulsLb.AutoSize = true;
            this.PulsLb.Location = new System.Drawing.Point(96, 187);
            this.PulsLb.Name = "PulsLb";
            this.PulsLb.Size = new System.Drawing.Size(35, 13);
            this.PulsLb.TabIndex = 8;
            this.PulsLb.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diastolisk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Systolisk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digitalt filter til:";
            // 
            // DigitalfilterChB
            // 
            this.DigitalfilterChB.AutoSize = true;
            this.DigitalfilterChB.Location = new System.Drawing.Point(463, 438);
            this.DigitalfilterChB.Name = "DigitalfilterChB";
            this.DigitalfilterChB.Size = new System.Drawing.Size(15, 14);
            this.DigitalfilterChB.TabIndex = 13;
            this.DigitalfilterChB.UseVisualStyleBackColor = true;
            // 
            // DataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DataChart.Legends.Add(legend1);
            this.DataChart.Location = new System.Drawing.Point(209, 50);
            this.DataChart.Name = "DataChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DataChart.Series.Add(series1);
            this.DataChart.Size = new System.Drawing.Size(770, 315);
            this.DataChart.TabIndex = 14;
            this.DataChart.Text = "chart1";
            // 
            // Måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 471);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.DigitalfilterChB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PulsLb);
            this.Controls.Add(this.DiaLb);
            this.Controls.Add(this.SysLb);
            this.Controls.Add(this.LogoutBt);
            this.Controls.Add(this.nulBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.AlarmBt);
            this.Controls.Add(this.MålingBt);
            this.Controls.Add(this.nulpunktBt);
            this.Name = "Måling";
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nulpunktBt;
        private System.Windows.Forms.Button MålingBt;
        private System.Windows.Forms.Button AlarmBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button nulBt;
        private System.Windows.Forms.Button LogoutBt;
        private System.Windows.Forms.Label SysLb;
        private System.Windows.Forms.Label DiaLb;
        private System.Windows.Forms.Label PulsLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox DigitalfilterChB;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
    }
}