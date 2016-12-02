﻿using System;
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
    public class Logic : SubjectLogic
    {
        private double ZeroA;
        private Dataaccess_blodtryksmåler.GetData DAL;
        public DTO_data dtoData;

        private Dataaccess_blodtryksmåler.Kalibrer kalval; 
        private GetAsyncDatalist raaDatalist;
        public SemaphoreSlim sema1;
        private Thread t;

        public Logic()
        {
            dtoData = new DTO_data();
            dtoData.datalist = new List<double>(1);
            sema1 = new SemaphoreSlim(1, 1);

            t = new Thread(sendData);

            

            //tråd = new Thread(fromVtommHg()); 

        }

        public void ReadData()
        {

        }

        public void start()
        {
            DAL = new Dataaccess_blodtryksmåler.GetData();
            DAL.OpsamlData();
            raaDatalist = new GetAsyncDatalist(DAL.daQmx, this);
            t.Start();
        }
        void sendData()
        {
            while (true)
            {
                
                Notify(ref dtoData);
                sema1.Wait();
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
