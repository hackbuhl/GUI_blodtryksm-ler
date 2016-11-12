using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
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
        private DTO_data dtoData;
        private Thread lT;
        private Thread kalT;
        private Dataaccess_blodtryksmåler.Kalibrer kalval;

        public Logic()
        {
            DAL = new Dataaccess_blodtryksmåler.GetData();
        }
        public DTO_data DatatoPresentation(int i)
        {
            return dtoData;
            //Denne metode skal sende dataen fra fromVtommHg op i præsentationslaget 
        }
        public void start(DTO_data dat)
        {
            dtoData.datalist = dat.datalist;
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
            dat = DAL.OpsamlData();
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
                dtoData = DAL.OpsamlData();
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
