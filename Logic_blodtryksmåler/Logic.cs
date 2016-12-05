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
        private double kal=1000;
        private Filter filter;
        public bool filterON;

        public Logic()
        {
            filterON = true;
            dtoData = new DTO_data();
            dtoData.datalist = new List<double>(1);
            sema1 = new SemaphoreSlim(1, 1);
            kalval = new Dataaccess_blodtryksmåler.Kalibrer();
            //kal = kalval.getFactor();
            t = new Thread(sendData);
            tk = new Thread(dataToKalibrate); 

            DAL = new GetData();


        }

        public void ReadData()
        {

        }

        public void start()
        {
            DAL.OpsamlData();
            raaDatalist = new GetAsyncDatalist(DAL.daQmx, this);
            t.Start();
        }

        public void stop()
        {
           t.Interrupt();
          
        }

        public void Continu()
        {
            t.Join();
        }

        public void startkal()
        {
            DAL.OpsamlData();
            raaDatalist = new GetAsyncDatalist(DAL.daQmx, this);
            tk.Start();
        }

        public void stopkal()
        {
            tk.Interrupt();
        }
        void sendData()
        {
            while (true)
            {
                if (filterON == true)
                {
                    sema1.Wait();
                    fromVtommHg(ref dtoData);
                   // filter.FilterData(ref dtoData);

                    Notify(ref dtoData);
                }
                else
                {
                    sema1.Wait();
                    fromVtommHg(ref dtoData);
                    Notify(ref dtoData);
                }

            }
        }

        public void fromVtommHg(ref DTO_data dat)
        {

            int ic;
            if (dat.datalist.Count>6)
            ic = dat.datalist.Count - 5;
            else
            {
                ic = 0;
            }

            for (int i =ic; i < dat.datalist.Count; i++)
            {
                dat.datalist[i] = (dat.datalist[i]-ZeroA)*kal;
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
                ZeroA = zeroDoubles.Average();
                
                return true;


        }
    }
}
