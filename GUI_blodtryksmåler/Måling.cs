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
using DTO_blodtryksmåler;
using Logic_blodtryksmåler;

//


namespace GUI_blodtryksmåler
{
    public partial class Måling : Form
    {
        private Logic_blodtryksmåler.Analyse dataanalyse=new Analyse();
        private DTO_blodtryksmåler.DTO_data DTO_Data=new DTO_data();
        private DTO_blodtryksmåler.DTO_login DTO_Login=new DTO_login();
        private Logic_blodtryksmåler.Logic log = new Logic_blodtryksmåler.Logic();

        // test

        private Thread cpuThread;
        private double[] cpuArray = new double[101];

        public Måling()
        {
            InitializeComponent();
        }
        public void Filter(bool on)
        {

        }
        public void UpdateChart()
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
        private void getPerformanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (DataChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(100);
            }
        }
       
        private void UpdateCpuChart()
        {
            DataChart.Series["Series1"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                DataChart.Series["Series1"].Points.AddY(cpuArray[i]);
            }
        }
        bool bln = true; //Får knappen til at skifte mellem start og stop måling
        private void MålingBt_Click(object sender, EventArgs e)
        {
            if (bln == true)
            {
             
                cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
                cpuThread.IsBackground = true;
                cpuThread.Start();

                log.ReadData();
                MålingBt.Text = "Stop måling";
                bln = false;
                nulBt.Enabled = false;
                SaveBt.Enabled = false;
                LogoutBt.Enabled = false;
                nulpunktBt.Enabled = false;
            }

            else
            {
                cpuThread.Abort();
                MålingBt.Text = "Start måling";
                bln = true;
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
                Logic_blodtryksmåler.Filter on = new Logic_blodtryksmåler.Filter();
                
            }
            else
            {

            }
        }

        private void DataChart_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBt_Click(object sender, EventArgs e)
        {

        }

        private void nulpunktBt_Click(object sender, EventArgs e)
        {
            nulBt.Enabled = true;
            SaveBt.Enabled = true;
            MålingBt.Enabled = true;
            AlarmBt.Enabled = true; 
           
            
        }
    }
}

