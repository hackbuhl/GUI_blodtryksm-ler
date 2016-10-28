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

namespace GUI_blodtryksmåler
{
    public partial class Kalibrer : Form
    {
        private Logic_blodtryksmåler.Kalibrer logKalibrer;
        private DTO_kalibrer dtoKali;
        private DTO_data dtoData;

        public Kalibrer()
        {
            InitializeComponent();
            logKalibrer.Update();
        }

        private void Tryk1Bt_Click(object sender, EventArgs e)
        {
            logKalibrer.Update();
            dtoKali.Måling1 = dtoData.datalist[0];
            try
            {

                dtoKali.Read1 = Convert.ToDouble(Tryk1TB.Text);

                Tryk1Bt.Enabled = false;
                Tryk2Bt.Enabled = true;

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
                dtoKali.Måling2 = dtoData.datalist[0];//korrekt plads skal sættes ind når filteret er specificeret.
                Tryk2Bt.Enabled = false;
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
            logKalibrer.Calibrate(dtoKali);
        }

        private void nulBt_Click(object sender, EventArgs e)
        {
            Tryk1TB.Text = null;
            Tryk2TB.Text = null;
            KaliBt.Enabled = false;
            Tryk2Bt.Enabled = false;
            Tryk1Bt.Enabled = true;
        }

        private void LogafBt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
