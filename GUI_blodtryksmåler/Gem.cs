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
    public partial class Gem : Form
    {
        DTO_blodtryksmåler.DTO_data DTO_data = new DTO_blodtryksmåler.DTO_data();
        DTO_blodtryksmåler.DTO_login DTO_login = new DTO_blodtryksmåler.DTO_login();
        Logic_blodtryksmåler.Gem Save = new Logic_blodtryksmåler.Gem(); 

        public Gem(DTO_blodtryksmåler.DTO_data DTO_da, DTO_blodtryksmåler.DTO_login DTO_log)
        {
            InitializeComponent();
            DTO_data = DTO_da;
            DTO_login = DTO_log;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int saved;
            DTO_data.CPR = CPRTb.Text;
            DTO_data.kommentar = NoteTb.Text;
            saved = Save.SaveBT(DTO_login, DTO_data);

            switch (saved)
            {
                case 1:
                    //gemt og valideret
                    MessageBox.Show("Data er gemt i databasen.");
                    Close();
                    break;

                case 2:
                    //valideret men ikke gemt
                    MessageBox.Show("Der er ikke forbindelse til databasen.");
                    break;

                case 3:
                    // CPR ikke valideret
                    MessageBox.Show("CPR er ugyldigt");
                    break;
            }
        }

        private void NoteTb_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
