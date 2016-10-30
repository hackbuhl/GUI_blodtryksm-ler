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
    public partial class Login : Form
    {
        private Logic_blodtryksmåler.Login login;
        private DTO_login dtoLogin;
        public Login()
        {
            InitializeComponent();
        }

        public DTO_login GetType(DTO_login log)
        {
            return login.getLogin(log);
        }

        private void Logon_Click(object sender, EventArgs e)
        {
            dtoLogin.id = Convert.ToInt32(IdTb.Text);
            dtoLogin.pass = Convert.ToString(PassTb.Text);
            GetType(dtoLogin);
            // luk login vindue og åben enten kalibrer eller måling



        }
    }
}
