using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO_blodtryksmåler;
using System.Threading;

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

        public void start()
        {

        }

        public void Execute(bool cal)
        {
            if (cal == true)
            {
                lT = new Thread(() => formVtommHg());
                lT.Start();
            }
            else
            {
                kalT = new Thread(()=> dataToKalibrate());
                kalT.Start();
            }
        }

        public DTO_data formVtommHg()
        {
            DTO_data dat = new DTO_data();
            dat = DAL.OpsamlData();
            List<double> list = new List<double>();
            foreach (var VARIABLE in dat.datalist)
            {
                list.Add( (VARIABLE*kalval.getFactor())-ZeroA);              
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
                list.Add(VARIABLE - ZeroA);
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
