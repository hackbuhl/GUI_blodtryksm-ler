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
        const string DB = "Lokaldatabasenavn";
        private DTO_login login;
        private SqlCommand myCommand;
        private SqlDataReader myReader;
        public bool DTO_login isUserinDB(DTO_login log)
        {
            //Ida Indtaster anden metode

            login = getType(log);
            
            return true;

        }
        public SqlConnection OpenConnectionST
        {
            get
            {
                
                var con = new SqlConnection("user id=" + DB +
                                            ";password=" + DB + ";server=i4dab.ase.au.dk;" +
                                            "Trusted_Connection=false;" +
                                            "connection timeout=5");
                con.Open();
                return con;
            }
        }

        public DTO_login getType(DTO_login log)
        {
          myCommand = new SqlCommand("SELECT Type FROM BtData where id='"+log.id+"'AND pass='"+log.pass+"'",OpenConnectionST);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                log.type = Convert.ToInt32(myReader["Type"]);
            }
            OpenConnectionST.Close();
            return log;
        }
    }
}