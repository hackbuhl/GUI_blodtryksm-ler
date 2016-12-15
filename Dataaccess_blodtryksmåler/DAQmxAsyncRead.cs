using System;
using NationalInstruments.DAQmx;

namespace Dataaccess_blodtryksmåler
{
    public class DAQmxAsyncRead : SubjectData
    {
        private AnalogSingleChannelReader reader = null;
        
        private int samplelenght = 100;

        public DAQmxAsyncRead(AnalogSingleChannelReader ACR)
        {
            //Create the reader
            reader = ACR;
            //Acquire 100 samples
            IAsyncResult handle = reader.BeginReadMultiSample(samplelenght, new AsyncCallback(OnDataReady), null);
        }

        public void OnDataReady(IAsyncResult i)
        {
            //Retrieve the data that was read.
            //At this point, any exceptions that occurred during the asynchronous read are thrown
            double[] data = reader.EndReadMultiSample(i);
            Notify(data);
            //You can call the BeginReadMultiSample method here agai
            reader.BeginReadMultiSample(samplelenght, new AsyncCallback(OnDataReady), null);
        }
    }
}
