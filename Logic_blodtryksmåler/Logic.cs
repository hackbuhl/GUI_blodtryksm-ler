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
    public class Logic : SubjectLogic
    {
        private double ZeroA;
        private Dataaccess_blodtryksmåler.GetData DAL;
        private DTO_data dtoData = new DTO_data();
        private Thread tråd; 
        private Dataaccess_blodtryksmåler.Kalibrer kalval; 
        private GetAsyncDatalist raaDatalist;

        public Logic()
        {
            //tråd = new Thread(fromVtommHg()); 
        }
        public void ReadData()
        {
            //DAL = new Dataaccess_blodtryksmåler.GetData();
            //raaDatalist = new GetAsyncDatalist(DAL.daQmx);
        }
        public void start(DTO_data dat)
        {
            foreach (var VARIABLE in dat.datalist)
            {
                dtoData.datalist.Add(VARIABLE);
            }
            Notify(dtoData);
        }
        public void DatatoPresentation(DTO_data dto_data)
        {
            Notify(dto_data);
            //Denne metode skal sende dataen fra fromVtommHg op i præsentationslaget 
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
            raaDatalist = new GetAsyncDatalist(DAL.daQmx);
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
