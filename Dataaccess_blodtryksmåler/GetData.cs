using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NationalInstruments.DAQmx;

namespace Dataaccess_blodtryksmåler
{
    public class GetData
    {

        private List<double> dataliste;
        private NI_DAQVoltage datacollector;
        public DAQmxAsyncRead daQmx;
        private AnalogSingleChannelReader reader;

        public GetData()
        {
            dataliste = new List<double>();
            datacollector = new NI_DAQVoltage();
            datacollector.samplesPerChannel = 500;
            datacollector.sampleRateInHz = 1000;
            datacollector.deviceName = "Dev1/ai0";
            //daQmx = new DAQmxAsyncRead(datacollector.getTask());
            reader = new AnalogSingleChannelReader(datacollector.getTask().Stream);
        }





//Opsaml data metroden skal vi ikke bruge data 
        public void OpsamlData()
        {
            daQmx = new DAQmxAsyncRead(reader);
        }

        public NI_DAQVoltage getDataCollector()
        {
            return datacollector;
        }

        public double[] SampleforZero()
        {
           
            return reader.ReadMultiSample(100);

        }
    }


    }

