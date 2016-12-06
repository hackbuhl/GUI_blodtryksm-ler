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
    public partial class Alarm : Form
    {
        private Logic_blodtryksmåler.Alarm alarm;
        private DTO_alarm dtoAlarm;

        public Alarm(Logic_blodtryksmåler.Alarm alanAlarm)
        {
            InitializeComponent();
            alarm = alanAlarm;
            dtoAlarm = new DTO_alarm();
        }

        private void grænseBt_Click(object sender, EventArgs e)
        {
            try
            {
                dtoAlarm.NedDia = Convert.ToInt32(NedDiaTb.Text);
                dtoAlarm.NedSys = Convert.ToInt32(NedSysTb.Text);
                dtoAlarm.ØvDia = Convert.ToInt32(ØvDiaTb.Text);
                dtoAlarm.ØvSys = Convert.ToInt32(ØvSysTb.Text);
                MessageBox.Show("Alarm indstillet");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Udfyld alle felter med positive heltal.");
            }
            alarm.setAlarm(dtoAlarm);
        }
    }
}
