using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;
using System.Threading.Tasks;

namespace Dataaccess_blodtryksmåler
{
    class DAQmxAsyncRead : SubjectData
    {
        private AnalogSingleChannelReader reader = null;
        private GetData get = new GetData();
        private int samplelenght = 100;

        public DAQmxAsyncRead(NationalInstruments.DAQmx.Task t)
        {
            //Create the reader
            reader = new AnalogSingleChannelReader(t.Stream);
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
