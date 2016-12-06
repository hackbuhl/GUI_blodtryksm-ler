using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_blodtryksmåler;
using Logic_blodtryksmåler;


namespace GUI_blodtryksmåler
{
    public partial class Kalibrer : Form, IObserverLogic
    {
        private Logic_blodtryksmåler.Logic logic;
        private Logic_blodtryksmåler.Kalibrer logKalibrer;
        private DTO_kalibrer dtoKali;
        private DTO_data dtoData;
        private DTO_login dtoLogin;

        public Kalibrer(DTO_login log)
        {
            dtoLogin = new DTO_login();
            dtoLogin = log;
            logic = new Logic();
            logKalibrer=  new Logic_blodtryksmåler.Kalibrer();
            dtoKali = new DTO_kalibrer();
            dtoData = new DTO_data();
            InitializeComponent();
            //logKalibrer.Update();


            logic.Attach(this);
            logic.startkal();

        }

        public void Update( ref DTO_data dtodata)
        {
            dtoData = dtodata;
        }

        private void Tryk1Bt_Click(object sender, EventArgs e)
        {
            try
            {
                dtoKali.Read1 = Convert.ToDouble(Tryk1TB.Text);


                List<double> avList = new List<double>();
                for (int i = dtoData.datalist.Count - 100; i < dtoData.datalist.Count; i++)
                {
                    avList.Add(dtoData.datalist[i]);
                }
                dtoKali.Måling1 = avList.Average();
                

                
                Tryk1Bt.Enabled = false;
                Tryk2Bt.Enabled = true;
                Tryk1TB.Enabled = false;
                Tryk2TB.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Den indtastede værdi skal være et tal.");
                Tryk1TB.Text = null;
            }

        }

        private void Tryk2Bt_Click(object sender, EventArgs e)
        {
            try
            {
                dtoKali.Read2 = Convert.ToDouble(Tryk2TB.Text);

                List<double> avList = new List<double>();
                for (int i = dtoData.datalist.Count - 100; i < dtoData.datalist.Count; i++)
                {
                    avList.Add(dtoData.datalist[i]);
                }
                dtoKali.Måling2 = avList.Average();
                

              
                Tryk2Bt.Enabled = false;
                Tryk2TB.Enabled = false;
                KaliBt.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Den indtastede værdi skal være et tal.");
                Tryk2TB.Text = null;
            }
        }

        private void KaliBt_Click(object sender, EventArgs e)
        {
            logKalibrer.Calibrate(dtoKali,dtoLogin);

        }

        private void nulBt_Click(object sender, EventArgs e)
        {
            Tryk1TB.Text = null;
            Tryk2TB.Text = null;
            KaliBt.Enabled = false;
            Tryk2Bt.Enabled = false;
            Tryk1Bt.Enabled = true;
            Tryk1TB.Enabled = true;
            Tryk2TB.Enabled = false;
        }

        private void LogafBt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

    }
}
