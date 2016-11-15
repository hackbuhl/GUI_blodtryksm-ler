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
    public partial class Måling : Form, Logic_blodtryksmåler.IObserverLogic
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
        public void Update(DTO_data dto)
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while (true)
            {

                double[] dataArray = dto.datalist.ToArray();

                Array.Copy(dataArray, 1, dataArray, 0, dataArray.Length - 1);

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

        private void MålingBt_Click(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.Update));
            cpuThread.IsBackground = true;
            cpuThread.Start();

            log.ReadData();

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

    }
}

