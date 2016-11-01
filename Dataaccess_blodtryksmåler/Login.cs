using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DTO_blodtryksmåler;


namespace Dataaccess_blodtryksmåler
{
    public class Login
    {
        const string DB = "F16ST2ITS2201505227";
        private DTO_login login = new DTO_login();
        private SqlCommand myCommand;
        private SqlDataReader myReader;
        private SqlConnection myConnection;
        

        public Login()
        {
            myConnection = new SqlConnection("user id=" + DB +
                                            ";password=" + DB + ";server=i4dab.ase.au.dk;" +
                                            "Trusted_Connection=false;" +
                                            "connection timeout=30");
        }

        public bool isUserinDB(DTO_login log)
        {
            //Ida indtaster anden metode

            myCommand = new SqlCommand("select * from Logintabel where BrugerID='" + log.id + "'and Kode='" + log.pass + "'", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                while (myReader.Read())
                {
                    log.type = Convert.ToString(myReader["BrugerType"]);
                }
                myConnection.Close();
            }

            else
            {
                log.type = "FalseId";
                myConnection.Close();
            }
            return log;



        }
    }
}