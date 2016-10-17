using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_blodtryksmåler
{
    public partial class Måling : Form
    {
        private Logic_blodtryksmåler.Analyse dataanalyse;
        private Logic_blodtryksmåler.Login login;
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
        public void UpdateAnalyse()
        {
        }
        public bool ZeroAdjust()
        {
            bool adjusted = false;
            return adjusted;
        }

    }
}
