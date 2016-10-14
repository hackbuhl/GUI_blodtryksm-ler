﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLag;

namespace Dataaccess_blodtryksmåler
{
    public class GetData
    {

        private NI_DAQVoltage datacollector;

        public int sampleFreq { get; set; }
        public int samples { get; set; }

        public GetData()
        {
        }
        public DTO_blodtryksmåler.DTO_data OpsamlData()
        {
            datacollector = new NI_DAQVoltage();

            sampleFreq = 500;
            samples = 5000;

            List<double> currentVoltageSeq;

            datacollector.samplesPerChannel = samples;
            datacollector.sampleRateInHz = sampleFreq;
            datacollector.deviceName = "Dev1/ai0";
            datacollector.getVoltageSeqBlocking();
            currentVoltageSeq = datacollector.currentVoltageSeq;

            int interval = samples / sampleFreq;

            return new DTO_blodtryksmåler.DTO_data(currentVoltageSeq, sampleFreq, interval);
        }

        public NI_DAQVoltage GetCollector()
        {
            throw new System.NotImplementedException();
        }

        public DTO_blodtryksmåler.DTO_data DataToDTO()
        {
            throw new System.NotImplementedException();
        }
    }
}
