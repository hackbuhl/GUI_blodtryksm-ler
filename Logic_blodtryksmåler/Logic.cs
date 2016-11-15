using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO_blodtryksmåler;


namespace Logic_blodtryksmåler
{
    public class Logic : iStrategy
    {
        private double ZeroA;
        private Dataaccess_blodtryksmåler.GetData DAL;
        private DTO_data dtoData = new DTO_data();
        private Thread lT;
        private Thread kalT;
        private Dataaccess_blodtryksmåler.Kalibrer kalval; 
        private GetAsyncDatalist raaDatalist;

        public Logic()
        {
            dtoData.datalist = new List<double>(1);
        }

        public void ReadData()
        {
            DAL = new Dataaccess_blodtryksmåler.GetData();
           
        }
        public void start(DTO_data dat)
        {
            foreach (var VARIABLE in dat.datalist)
            {
                dtoData.datalist.Add(VARIABLE);
            }
        }


        public DTO_data DatatoPresentation(int i)
        {
            return dtoData;
            //Denne metode skal sende dataen fra fromVtommHg op i præsentationslaget 
        }
        public void Execute(bool cal)
        {
            if (cal == true)
            {
                lT = new Thread(() => fromVtommHg());
                lT.Start();
            }
            else
            {
                kalT = new Thread(()=> dataToKalibrate());
                kalT.Start();
            }
        }

        public DTO_data fromVtommHg()
        {
            DTO_data dat = new DTO_data();
            dat = dataToKalibrate();
            double kal = kalval.getFactor();
            List<double> list = new List<double>();
            foreach (var VARIABLE in dat.datalist)
            {
                list.Add(VARIABLE*kal);
            }
            dat.datalist = list;
            return dat;

        }

        public DTO_data dataToKalibrate()
        {
            DTO_data dat = new DTO_data();
            
            List<double> list = new List<double>();
            foreach (var VARIABLE in dat.datalist)
            {
                list.Add(VARIABLE -ZeroA);
            }
            dat.datalist = list;
            return dat;

        }

        public bool ZeroAdjust()
        {
            try
            {
                //dtoData = DAL.OpsamlData();
                            DAL = new Dataaccess_blodtryksmåler.GetData();
            raaDatalist = new GetAsyncDatalist(DAL.daQmx,this);
                ZeroA = dtoData.datalist.Average();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
