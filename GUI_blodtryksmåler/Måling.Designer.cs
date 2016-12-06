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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MålingBt = new System.Windows.Forms.Button();
            this.AlarmBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.nulBt = new System.Windows.Forms.Button();
            this.SysLb = new System.Windows.Forms.Label();
            this.DiaLb = new System.Windows.Forms.Label();
            this.PulsLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DigitalfilterChB = new System.Windows.Forms.CheckBox();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logOutBt = new System.Windows.Forms.Button();
            this.nulpunktsBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MålingBt
            // 
            this.MålingBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MålingBt.Enabled = false;
            this.MålingBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MålingBt.Location = new System.Drawing.Point(312, 692);
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
            this.AlarmBt.Location = new System.Drawing.Point(801, 648);
            this.AlarmBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlarmBt.Name = "AlarmBt";
            this.AlarmBt.Size = new System.Drawing.Size(237, 71);
            this.AlarmBt.TabIndex = 2;
            this.AlarmBt.Text = "Opsæt Alarm";
            this.AlarmBt.UseVisualStyleBackColor = false;
            this.AlarmBt.Click += new System.EventHandler(this.AlarmBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveBt.Enabled = false;
            this.SaveBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBt.Location = new System.Drawing.Point(1227, 692);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(256, 109);
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
            this.nulBt.Location = new System.Drawing.Point(1227, 595);
            this.nulBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nulBt.Name = "nulBt";
            this.nulBt.Size = new System.Drawing.Size(256, 71);
            this.nulBt.TabIndex = 4;
            this.nulBt.Text = "Nulstil";
            this.nulBt.UseVisualStyleBackColor = false;
            // 
            // SysLb
            // 
            this.SysLb.AutoSize = true;
            this.SysLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.SysLb.ForeColor = System.Drawing.Color.DarkOrange;
=======
            this.SysLb.ForeColor = System.Drawing.Color.Red;
>>>>>>> origin/master
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
<<<<<<< HEAD
            this.DiaLb.ForeColor = System.Drawing.Color.LimeGreen;
=======
            this.DiaLb.ForeColor = System.Drawing.Color.Red;
>>>>>>> origin/master
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
<<<<<<< HEAD
            this.PulsLb.ForeColor = System.Drawing.Color.Red;
=======
            this.PulsLb.ForeColor = System.Drawing.Color.Gray;
>>>>>>> origin/master
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
            this.label1.Location = new System.Drawing.Point(44, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 82);
            this.label1.TabIndex = 9;
            this.label1.Text = "130";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
=======
            this.label2.ForeColor = System.Drawing.Color.Gray;
>>>>>>> origin/master
            this.label2.Location = new System.Drawing.Point(105, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diastolisk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
=======
            this.label3.ForeColor = System.Drawing.Color.Gray;
>>>>>>> origin/master
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
            this.DigitalfilterChB.Checked = true;
            this.DigitalfilterChB.CheckState = System.Windows.Forms.CheckState.Checked;
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
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScaleView.Size = 500D;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.Title = "1/100 s";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Title = "mmHg";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BorderColor = System.Drawing.Color.DarkRed;
            chartArea1.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DataChart.Legends.Add(legend1);
            this.DataChart.Location = new System.Drawing.Point(273, 102);
            this.DataChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataChart.Name = "DataChart";
            this.DataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderWidth = 3;
            series1.LabelForeColor = System.Drawing.Color.DarkRed;
            series1.Legend = "Legend1";
            series1.Name = "series1";
            this.DataChart.Series.Add(series1);
            this.DataChart.Size = new System.Drawing.Size(1443, 432);
            this.DataChart.TabIndex = 0;
            this.DataChart.Text = "chart1";
            title1.Name = "Blodtryk";
            this.DataChart.Titles.Add(title1);
            // 
            // logOutBt
            // 
            this.logOutBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logOutBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutBt.Location = new System.Drawing.Point(1336, 51);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(130, 42);
            this.logOutBt.TabIndex = 15;
            this.logOutBt.Text = "Log af";
            this.logOutBt.UseVisualStyleBackColor = false;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click_1);
            // 
            // nulpunktsBt
            // 
            this.nulpunktsBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nulpunktsBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nulpunktsBt.Location = new System.Drawing.Point(312, 595);
            this.nulpunktsBt.Name = "nulpunktsBt";
            this.nulpunktsBt.Size = new System.Drawing.Size(278, 68);
            this.nulpunktsBt.TabIndex = 16;
            this.nulpunktsBt.Text = "Foretag nulpunktsjustering";
            this.nulpunktsBt.UseVisualStyleBackColor = false;
            this.nulpunktsBt.Click += new System.EventHandler(this.nulpunktsBt_Click);
            // 
            // Måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1594, 822);
            this.Controls.Add(this.nulpunktsBt);
            this.Controls.Add(this.logOutBt);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.DigitalfilterChB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PulsLb);
            this.Controls.Add(this.DiaLb);
            this.Controls.Add(this.SysLb);
            this.Controls.Add(this.nulBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.AlarmBt);
            this.Controls.Add(this.MålingBt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Måling";
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MålingBt;
        private System.Windows.Forms.Button AlarmBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button nulBt;
        private System.Windows.Forms.Label SysLb;
        private System.Windows.Forms.Label DiaLb;
        private System.Windows.Forms.Label PulsLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox DigitalfilterChB;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.Button logOutBt;
        private System.Windows.Forms.Button nulpunktsBt;
    }
}