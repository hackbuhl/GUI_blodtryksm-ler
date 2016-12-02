﻿using System;
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
        private Logic_blodtryksmåler.Analyse dataanalyse=new Analyse();
        private DTO_blodtryksmåler.DTO_data DTO_Data=new DTO_data();
        private DTO_blodtryksmåler.DTO_login DTO_Login=new DTO_login();
        private Logic_blodtryksmåler.Logic log;
        public int i = 0;

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
                DataChart.Series["series1"].Points.Clear();
            if (dto.datalist.Count < 500)
            {
                i = 0;
            }
            else
            {
                i = dto.datalist.Count - 500;
            }
                for (int ib=i; ib < dto.datalist.Count; ib++)
                {
                    
                    DataChart.Series["series1"].Points.AddY(dto.datalist[ib]);

            }
            

        }
        
  
        private void MålingBt_Click(object sender, EventArgs e)
        {
  
            
            log.Attach(this);
            log.start();
 
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
            DataChart.BeginInvoke((Action) (() => UpdateChart(DTO_Data)));
        }
    }
}

