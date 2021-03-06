﻿using System;
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
    public partial class Login : Form
    {
        private Logic_blodtryksmåler.Login login = new Logic_blodtryksmåler.Login();
        private DTO_login dtoLogin = new DTO_login();
        private Logic_blodtryksmåler.Logic LOG;


        public Login()
        {
            InitializeComponent();
            PassTb.PasswordChar = '*';
            PassTb.MaxLength = 4;
            LOG = new Logic();

        }

        public DTO_login GetType(DTO_login log)
        {
            return login.getLogin(log);
        }

        private void Logon_Click(object sender, EventArgs e)
        {
            try
            {
                dtoLogin.id = Convert.ToInt32(IdTb.Text);
                dtoLogin.pass = Convert.ToString(PassTb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Det indtastede brugernavn skal bestå af tal");
            }
            dtoLogin = login.getLogin(dtoLogin);
            // luk login vindue og åben enten kalibrer eller måling
            CheckType(dtoLogin);


        }

        private void CheckType (DTO_login log)
        {

                switch (log.type)
                {
                    case "Bruger":
                        Måling målingform = new Måling(LOG, log, this);
                        this.Hide();
                        målingform.ShowDialog();
                        IdTb.Clear();
                        PassTb.Clear();
                        break;
                    case "Tekniker":
                        Kalibrer kalibrerform = new Kalibrer(LOG, log, this);
                        this.Hide();
                        kalibrerform.ShowDialog();
                        IdTb.Clear();
                        PassTb.Clear();
                        break;
                    default:
                        MessageBox.Show("Ugyldigt brugernavn eller password");
                        IdTb.Clear();
                        PassTb.Clear();
                        break;
                }
            }
        }
    }

