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
        private SqlDataReader myReader;
        private SqlCommand myCommand;
        private const string DB = "F16ST2ITS2201505227";
        private GetData _getData = new GetData();

        private Login Login
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int SaveBT(DTO_data BTdata, DTO_login login)
        {
            int curId = 0;

            string insertStringParam = @"INSERT INTO Data 
            //(Dato, Blodtryk, PatientCPR, BrugerID, Noter)
            // OUTPUT INSERTED.ekgdataid
            // VALUES(@data, @id, @samplerate_hz, @interval_sec, @data_format, @bin_eller_tekst, @maaleformat_type, @start_tid, @kommentar)";


            List<double> data = BTdata.datalist;

            using (SqlCommand cmd = new SqlCommand(insertStringParam, Login.OpenConnectionST ))

            {

                // Get your parameters ready                    

                //cmd.Parameters.AddWithValue("@data", data.ToArray().SelectMany(value => BitConverter.GetBytes(value)).ToArray());
                //cmd.Parameters.AddWithValue("@samplerate_hz", (float)BTdata.samplerate_hz);
                //cmd.Parameters.AddWithValue("@data_format", EKGData.data_format);
                //cmd.Parameters.AddWithValue("@bin_eller_tekst", EKGData.bin_eller_tekst);
                //cmd.Parameters.AddWithValue("@maaleformat_type", EKGData.maaleformat_type);
                //cmd.Parameters.AddWithValue("@interval_sec", EKGData.interval_sek);
                //cmd.Parameters.AddWithValue("@start_tid", EKGData.start_tid);
                //cmd.Parameters.AddWithValue("@id", EKGData.ekgmaaleid);
                //cmd.Parameters.AddWithValue("@kommentar", EKGData.kommentar);


                var id = cmd.ExecuteScalar(); //Returns the identity of the new tuple/record                
                curId = Convert.ToInt32(id);
            }

            return curId;
        }
    }
    }