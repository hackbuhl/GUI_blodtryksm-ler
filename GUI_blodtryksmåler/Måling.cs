using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading; // 
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using DTO_blodtryksmåler;
using Logic_blodtryksmåler;

//


namespace GUI_blodtryksmåler
{
    public partial class Måling : Form, Logic_blodtryksmåler.IObserverLogic
    {
        private Logic_blodtryksmåler.Analyse dataanalyse = new Analyse();
        private DTO_blodtryksmåler.DTO_data DTO_Data = new DTO_data();
        private DTO_blodtryksmåler.DTO_login DTO_Login = new DTO_login();
        private Logic_blodtryksmåler.Logic log;
        public int i = 0;
        int caseSwitch = 1;

        // test

        public Måling()
        {
            InitializeComponent();
            log = new Logic();
        }


        public void Filter(bool on)
        {

        }

        public void DrawGraph()
        {
        }

        public void UpdateAnalyse()
        {
        }
        public bool ZeroAdjust()
        {
            bool adjusted = false;
            return adjusted;
        }


        // test
        public void UpdateChart(DTO_data dto)
        {

            int i;
            if (dto.datalist.Count > 11)
            {

                DataChart.Series["series1"].Points.Clear();
                if (dto.datalist.Count < 500)
                {
                    i = 0;
                }
                else
                {
                    i = dto.datalist.Count - 500;
                }
                for (int ib = i+10; ib < dto.datalist.Count; ib++)
                {

                    DataChart.Series["series1"].Points.AddY(dto.datalist[ib - 10]);

                }

            }
            DiaLb.Text = Convert.ToString(DTO_Data.Diastole);
            SysLb.Text = Convert.ToString(DTO_Data.Systole);
        }


        private void MålingBt_Click(object sender, EventArgs e)
        {

            
            switch (caseSwitch)
            {
                case 1:
                    log.Attach(this);
                    log.Start();
                    MålingBt.Text = "Stop Måling";
                    caseSwitch = 2;
                    break;

                case 2:
                    
                    log.Stop();
                    MålingBt.Text = "Start Måling";
                    caseSwitch = 3;
                    break;

                case 3:
                    log.Attach(this);
                    log.Continu();
                    MålingBt.Text = "Stop Måling";
                    caseSwitch = 2;
                    break;
                    

                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            Gem gem = new Gem(DTO_Data, DTO_Login);
            gem.ShowDialog();
        }


        private void DigitalfilterChB_CheckedChanged(object sender, EventArgs e)
        {
            if (DigitalfilterChB.Checked)
            {
                log.filterON = true;

            }
            else
            {
                log.filterON = false;
            }
        }

        private void DataChart_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBt_Click(object sender, EventArgs e)
        {

        }

        private void nulpunktsBt_Click(object sender, EventArgs e)
        {
            nulBt.Enabled = true;
            SaveBt.Enabled = true;
            MålingBt.Enabled = true;
            AlarmBt.Enabled = true;
            log.ZeroAdjust();
        }

        private void AlarmBt_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm();
            alarm.ShowDialog();
        }

        public void Update(ref DTO_data dto)
        {
            DTO_Data = dto;
            DataChart.BeginInvoke((Action)(() => UpdateChart(DTO_Data)));
        }

        private void logOutBt_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(); 
        }
    }
}

