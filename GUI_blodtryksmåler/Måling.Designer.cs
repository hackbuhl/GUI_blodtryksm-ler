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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.nulpunktBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nulpunktBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nulpunktBt.Location = new System.Drawing.Point(312, 596);
            this.nulpunktBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nulpunktBt.Name = "nulpunktBt";
            this.nulpunktBt.Size = new System.Drawing.Size(278, 71);
            this.nulpunktBt.TabIndex = 0;
            this.nulpunktBt.Text = "Foretag nulpunktsjustering";
            this.nulpunktBt.UseVisualStyleBackColor = true;
            this.nulpunktBt.Click += new System.EventHandler(this.nulpunktBt_Click);
            // 
            // MålingBt
            // 
            this.MålingBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MålingBt.Enabled = false;
            this.MålingBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MålingBt.Location = new System.Drawing.Point(312, 693);
            this.MålingBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MålingBt.Name = "MålingBt";
            this.MålingBt.Size = new System.Drawing.Size(278, 109);
            this.MålingBt.TabIndex = 1;
            this.MålingBt.Text = "Start Måling";
            this.MålingBt.UseVisualStyleBackColor = false;
            this.MålingBt.Click += new System.EventHandler(this.MålingBt_Click);
            // 
            // AlarmBt
            // 
            this.AlarmBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AlarmBt.Enabled = false;
            this.AlarmBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlarmBt.Location = new System.Drawing.Point(801, 647);
            this.AlarmBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlarmBt.Name = "AlarmBt";
            this.AlarmBt.Size = new System.Drawing.Size(237, 71);
            this.AlarmBt.TabIndex = 2;
            this.AlarmBt.Text = "Opsæt Alarm";
            this.AlarmBt.UseVisualStyleBackColor = false;
            // 
            // SaveBt
            // 
            this.SaveBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveBt.Enabled = false;
            this.SaveBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBt.Location = new System.Drawing.Point(1227, 693);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(257, 109);
            this.SaveBt.TabIndex = 3;
            this.SaveBt.Text = "Gem Måling";
            this.SaveBt.UseVisualStyleBackColor = false;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // nulBt
            // 
            this.nulBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nulBt.Enabled = false;
            this.nulBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nulBt.Location = new System.Drawing.Point(1227, 596);
            this.nulBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nulBt.Name = "nulBt";
            this.nulBt.Size = new System.Drawing.Size(257, 71);
            this.nulBt.TabIndex = 4;
            this.nulBt.Text = "Nulstil";
            this.nulBt.UseVisualStyleBackColor = false;
            // 
            // LogoutBt
            // 
            this.LogoutBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogoutBt.ForeColor = System.Drawing.Color.White;
            this.LogoutBt.Location = new System.Drawing.Point(1372, 43);
            this.LogoutBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutBt.Name = "LogoutBt";
            this.LogoutBt.Size = new System.Drawing.Size(112, 48);
            this.LogoutBt.TabIndex = 5;
            this.LogoutBt.Text = "Log af";
            this.LogoutBt.UseVisualStyleBackColor = true;
            this.LogoutBt.Click += new System.EventHandler(this.LogoutBt_Click);
            // 
            // SysLb
            // 
            this.SysLb.AutoSize = true;
            this.SysLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysLb.ForeColor = System.Drawing.Color.Red;
            this.SysLb.Location = new System.Drawing.Point(10, 85);
            this.SysLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SysLb.Name = "SysLb";
            this.SysLb.Size = new System.Drawing.Size(207, 108);
            this.SysLb.TabIndex = 6;
            this.SysLb.Text = "130";
            // 
            // DiaLb
            // 
            this.DiaLb.AutoSize = true;
            this.DiaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaLb.ForeColor = System.Drawing.Color.Red;
            this.DiaLb.Location = new System.Drawing.Point(82, 269);
            this.DiaLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiaLb.Name = "DiaLb";
            this.DiaLb.Size = new System.Drawing.Size(109, 64);
            this.DiaLb.TabIndex = 7;
            this.DiaLb.Text = "/75";
            // 
            // PulsLb
            // 
            this.PulsLb.AutoSize = true;
            this.PulsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PulsLb.ForeColor = System.Drawing.Color.Gray;
            this.PulsLb.Location = new System.Drawing.Point(129, 489);
            this.PulsLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PulsLb.Name = "PulsLb";
            this.PulsLb.Size = new System.Drawing.Size(42, 20);
            this.PulsLb.TabIndex = 8;
            this.PulsLb.Text = "Puls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 82);
            this.label1.TabIndex = 9;
            this.label1.Text = "130";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(105, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diastolisk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(111, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Systolisk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(849, 600);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digitalt filter til:";
            // 
            // DigitalfilterChB
            // 
            this.DigitalfilterChB.AutoSize = true;
            this.DigitalfilterChB.Location = new System.Drawing.Point(969, 600);
            this.DigitalfilterChB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DigitalfilterChB.Name = "DigitalfilterChB";
            this.DigitalfilterChB.Size = new System.Drawing.Size(22, 21);
            this.DigitalfilterChB.TabIndex = 13;
            this.DigitalfilterChB.UseVisualStyleBackColor = true;
            this.DigitalfilterChB.CheckedChanged += new System.EventHandler(this.DigitalfilterChB_CheckedChanged);
            // 
            // DataChart
            // 
            this.DataChart.BackColor = System.Drawing.Color.Transparent;
            this.DataChart.BorderlineWidth = 2;
            this.DataChart.BorderSkin.BackColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.ScaleView.Size = 100D;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.DarkRed;
            chartArea2.AxisX.Title = "ms";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.Title = "mmHg";
            chartArea2.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DataChart.Legends.Add(legend2);
            this.DataChart.Location = new System.Drawing.Point(273, 101);
            this.DataChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataChart.Name = "DataChart";
            this.DataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "series1";
            this.DataChart.Series.Add(series2);
            this.DataChart.Size = new System.Drawing.Size(1443, 432);
            this.DataChart.TabIndex = 0;
            this.DataChart.Text = "chart1";
            title2.Name = "Blodtryk";
            this.DataChart.Titles.Add(title2);
            // 
            // Måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1711, 841);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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