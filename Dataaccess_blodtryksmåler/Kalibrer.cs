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

        public Kalibrer()
        {
            myConnection = new SqlConnection("user id=" + DB +
                                             ";password=" + DB + ";server=i4dab.ase.au.dk;" +
                                             "Trusted_Connection=false;" +
                                             "connection timeout=5");
        }

        public bool saveFactor(DTO_kalibrer kal, DTO_login log)
        {
            // try
            //{
            SqlCommand cmd =
                new SqlCommand("INSERT INTO Kalibrer (Dato,BrugerID,Factor) VALUES (@Dato,@BrugerID,@Factor)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = myConnection;
            cmd.Parameters.AddWithValue("@Dato", DateTime.Today);
            cmd.Parameters.AddWithValue("@BrugerId", log.id);
            cmd.Parameters.AddWithValue("@Factor", kal.Factor);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

        public double getFactor()
        {
            double factor=0;
            myCommand = new SqlCommand("SELECT MAX(dato),Factor from Kalibrer", myConnection);
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
