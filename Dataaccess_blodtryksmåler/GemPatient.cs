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
        private GetData _getData = new GetData();

        public GemPatient()
        {
            myConnection = new SqlConnection("user id=" + DB +
                                ";password=" + DB + ";server=i4dab.ase.au.dk;" +
                                "Trusted_Connection=false;" +
                                "connection timeout=5");
        }

        public int SaveBT(DTO_data BTdata, DTO_login login)
        {

            string insertStringParam = @"INSERT INTO Data 
            //(Dato, Blodtryk, PatientCPR, BrugerID, Noter)
            // OUTPUT INSERTED.ekgdataid
            // VALUES(@Dato, @Blodtryk, @PatientCPR, @BrugerID, @Noter)";


            List<double> data = BTdata.datalist;
            try
            {
                using (SqlCommand cmd = new SqlCommand(insertStringParam, myConnection))

                {

                    // Get your parameters ready                    

                    cmd.Parameters.AddWithValue("@Dato", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Blodtryk", data.ToArray().SelectMany(value => BitConverter.GetBytes(value)).ToArray());
                    cmd.Parameters.AddWithValue("@PatientCPR", BTdata.CPR);
                    cmd.Parameters.AddWithValue("@BrugerID", login.id);
                    cmd.Parameters.AddWithValue("@Noter", BTdata.kommentar);

                }
                return 1;
                
            }
            catch (Exception)
            {
                return   2; }



        }
    }
    }