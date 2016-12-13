using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using  DTO_blodtryksmåler;

namespace Dataaccess_blodtryksmåler
{
    public class GemPatient
    {
        private SqlConnection myConnection;
        private const string DB = "F16ST2ITS2201505227";

        private int id;

        public GemPatient()
        {
            myConnection = new SqlConnection("user id=" + DB +
                                ";password=" + DB + ";server=i4dab.ase.au.dk;" +
                                "Trusted_Connection=false;" +
                                "connection timeout=30");
        }

        public SqlConnection OpenConnection_
        {
            get
            {
                var con = new SqlConnection(@"Data Source=i4dab.ase.au.dk;Initial Catalog=" + DB + ";Integrated Security=False;User ID=" + DB + ";Password=" + DB + ";Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                return con;
            }
        }


        public int SaveBT(DTO_data BTdata, DTO_login login)
        {

            string insertStringParam = @"INSERT INTO Data(Dato, Blodtryk, PatientCPR, BrugerID, Noter) 
                                        VALUES(@Dato, @Blodtryk, @PatientCPR, @BrugerID, @Noter)";

            List<double> data = BTdata.datalist;
            var x = data.ToArray().SelectMany(value => BitConverter.GetBytes(value)).ToArray();

            try
            {
                using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection_))

                {
                    cmd.Parameters.AddWithValue("@Dato", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Blodtryk", x);
                    cmd.Parameters.AddWithValue("@PatientCPR", BTdata.CPR);
                    cmd.Parameters.AddWithValue("@BrugerID", login.id);
                    cmd.Parameters.AddWithValue("@Noter", BTdata.kommentar);
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                return 1;
            }



            catch (Exception)
            {
                return 2;
            }
        }
    }
}