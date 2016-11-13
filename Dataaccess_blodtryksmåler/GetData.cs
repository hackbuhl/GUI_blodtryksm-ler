using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dataaccess_blodtryksmåler
{
    public class GetData
    {

        private List<double> dataliste;
        private NI_DAQVoltage datacollector;
        public DAQmxAsyncRead daQmx;

        public GetData()
        {
            dataliste = new List<double>();
            datacollector = new NI_DAQVoltage();
            datacollector.samplesPerChannel = 500;
            datacollector.sampleRateInHz = 1000;
            datacollector.deviceName = "Dev1/ai0";
            daQmx = new DAQmxAsyncRead(datacollector.getTask());
        }





//Opsaml data metroden skal vi ikke bruge data 
        public void OpsamlData()
        {
            daQmx = new DAQmxAsyncRead(datacollector.getTask());
        }

        public NI_DAQVoltage getDataCollector()
        {
            return datacollector;
        }


        //    private NI_DAQVoltage datacollector;

        //    public int sampleFreq { get; set; }
        //    public int samples { get; set; }

        //    public GetData()
        //    {
        //    }
        //    public DTO_blodtryksmåler.DTO_data OpsamlData()
        //    {
        //        datacollector = new NI_DAQVoltage();

        //        sampleFreq = 500;
        //        samples = 5000;

        //        List<double> currentVoltageSeq;

        //        datacollector.samplesPerChannel = samples;
        //        datacollector.sampleRateInHz = sampleFreq;
        //        datacollector.deviceName = "Dev1/ai0";
        //        datacollector.getVoltageSeqBlocking();
        //        currentVoltageSeq = datacollector.currentVoltageSeq;

        //        int interval = samples / sampleFreq;

        //        return new DTO_blodtryksmåler.DTO_data(currentVoltageSeq, sampleFreq, interval);
        //    }

        //    public NI_DAQVoltage GetCollector()
        //    {
        //        throw new System.NotImplementedException();
        //    }

        //    public DTO_blodtryksmåler.DTO_data DataToDTO()
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //}
    }
}
