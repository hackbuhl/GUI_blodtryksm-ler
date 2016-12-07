using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dataaccess_blodtryksmåler;
using DTO_blodtryksmåler;


namespace Logic_blodtryksmåler
{
    public class Logic : SubjectLogic
    {
        private double ZeroA;
        private Dataaccess_blodtryksmåler.GetData DAL;
        public DTO_data dtoData;

        private Dataaccess_blodtryksmåler.Kalibrer kalval;
        private GetAsyncDatalist raaDatalist;
        public SemaphoreSlim sema1;
        private Thread t;
        private Thread tk;
        private double kal  = 12;
        private Filter filter;
        
        public bool filterON;
        public int errorstate;

        public Logic()
        {
            filterON = true;
            dtoData = new DTO_data();
            dtoData.datalist = new List<double>(1);
            sema1 = new SemaphoreSlim(1, 1);
            filter = new Filter();

                kalval = new Dataaccess_blodtryksmåler.Kalibrer();
                kal = kalval.getFactor();



            t = new Thread(sendData);
            tk = new Thread(dataToKalibrate);


                DAL = new GetData();





        }

        public void Start()
        {
            DAL.OpsamlData();
            raaDatalist = new GetAsyncDatalist(DAL.daQmx, this);
            t.Start();
        }

        public void Stop()
        {
            raaDatalist.stop(DAL.daQmx);

        }

        public void Continu()
        {
            raaDatalist.start(DAL.daQmx);
        }

        public void startkal()
        {
            DAL.OpsamlData();
            raaDatalist = new GetAsyncDatalist(DAL.daQmx, this);
            tk.Start();
        }

        public void stopkal()
        {
            raaDatalist.stop(DAL.daQmx);
        }

        void sendData()
        {
            while (true)
            {

                    sema1.Wait();
                    fromVtommHg(ref dtoData);
                    filter.FilterData(ref dtoData, filterON);
                    Notify(ref dtoData);
            }
        }

        public void fromVtommHg(ref DTO_data dat)
        {
            int ic;
            if (dat.datalist.Count > 6)
                ic = dat.datalist.Count - 5;
            else
            {
                ic = 0;
            }

            for (int i = ic; i < dat.datalist.Count; i++)
            {
                dat.datalist[i] = (dat.datalist[i]*kal)+ZeroA;
            }
        }

        void dataToKalibrate()
        {
            while (true)
            {
                sema1.Wait();
                Notify(ref dtoData);

            }


        }

        public bool ZeroAdjust()
        {
            double[] zeroDoubles = new double[1];

                zeroDoubles = DAL.SampleforZero();

            

                
                ZeroA = zeroDoubles.Average()*kal;    
                return true;
        }

        public Alarm GetAlarm()
        {
            return filter.GetAlarm();
        }
    }
}
