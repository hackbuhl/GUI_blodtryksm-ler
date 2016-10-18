using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_blodtryksmåler;

namespace GUI_blodtryksmåler
{
    public partial class Alarm : Form
    {
        private Logic_blodtryksmåler.Alarm alarm;
        private DTO_blodtryksmåler.DTO_alarm dtoAlarm;

        public Alarm()
        {
            InitializeComponent();
            alarm = new Logic_blodtryksmåler.Alarm();
        }

        private void grænseBt_Click(object sender, EventArgs e)
        {
            try
            {
                dtoAlarm.NedDia = Convert.ToInt32(NedDiaTb);
                dtoAlarm.NedSys = Convert.ToInt32(NedSysTb);
                dtoAlarm.ØvDia = Convert.ToInt32(ØvDiaTb);
                dtoAlarm.ØvSys = Convert.ToInt32(ØvSysTb);
            }
            catch (Exception)
            {

                MessageBox.Show("Udflyd alle felter med positive heltal.");
            }
            alarm.SetAlarm(dtoAlarm);
        }
    }
}
