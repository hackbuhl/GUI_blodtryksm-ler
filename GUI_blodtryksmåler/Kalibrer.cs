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
    public partial class Kalibrer : Form
    {
        private Logic_blodtryksmåler.Logic logic = new Logic();
        private Logic_blodtryksmåler.Kalibrer logKalibrer = new Logic_blodtryksmåler.Kalibrer();
        private DTO_kalibrer dtoKali;
        private DTO_data dtoData=new DTO_data();
        private DTO_login dtoLogin;

        public Kalibrer()
        {
            logic.ReadData();
            dtoKali = new DTO_kalibrer();
            InitializeComponent();
            //logKalibrer.Update();


           
        }

        public Kalibrer(DTO_login login)
        {
            InitializeComponent();
            
            dtoLogin = login;
        }

        private void Tryk1Bt_Click(object sender, EventArgs e)
        {
            //logKalibrer.Update();

            try
            {

                dtoKali.Read1 = Convert.ToDouble(Tryk1TB.Text);
                //logKalibrer.data();
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
                dtoKali.Måling2 = 5; //dtoData.datalist[0];//korrekt plads skal sættes ind når filteret er specificeret.
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
            throw new NotImplementedException();
        }

        private void ZeroAdjust_Click(object sender, EventArgs e)
        {
            logic.ZeroAdjust();
            ZeroAdjust.Enabled = false;
        }
    }
}
