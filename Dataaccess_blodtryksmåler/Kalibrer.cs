using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_blodtryksmåler;

namespace Dataaccess_blodtryksmåler
{
    public class Kalibrer
    {
        const string DB = "F16ST2ITS2201505227";
        private SqlCommand myCommand;
        private SqlDataReader myReader;
        private SqlConnection myConnection;
        private int id; 

        public Kalibrer()
        {
            myConnection = new SqlConnection("user id=" + DB +
                                             ";password=" + DB + ";server=i4dab.ase.au.dk;" +
                                             "Trusted_Connection=false;" +
                                             "connection timeout=30"); // ændret fra 5 til 
        }


        // test
        public SqlConnection OpenConnection_
        {
            get
            {
                var con = new SqlConnection(@"Data Source=i4dab.ase.au.dk;Initial Catalog=" + DB + ";Integrated Security=False;User ID=" + DB + ";Password=" + DB + ";Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                return con;
            }
        }


        public void saveFactor(DTO_kalibrer kal, DTO_login log) // ændret fra void til bool
        {
            DTO_kalibrer kal_ = kal;
            DTO_login log_ = log;


             string insertStringKalibrer = @"INSERT INTO Kalibrer(Dato, BrugerID, Factor) VALUES(@Dato, @BrugerID, @Factor)";

            using (SqlCommand cmd = new SqlCommand(insertStringKalibrer, OpenConnection_))
            {
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = myConnection;
                cmd.Parameters.AddWithValue("@Dato", DateTime.Today);
                cmd.Parameters.AddWithValue("@BrugerId", log.id);
                cmd.Parameters.AddWithValue("@Factor", kal.Factor);
                //myConnection.Open();
                //cmd.ExecuteNonQuery();
                id = Convert.ToInt32(cmd.ExecuteScalar()); 
            }
        }

        public double getFactor()
        {
            double factor = 0;


            string getFactorSQL = "SELECT TOP 1 * FROM Kalibrer ORDER BY Dato Desc";

            myCommand = new SqlCommand(getFactorSQL, myConnection); 
                                                                              


            myConnection.Open();
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                factor = Convert.ToDouble(myReader["Factor"]);
            }
            myConnection.Close();
            return factor;
        }
    }
}
