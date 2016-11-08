using System;
using System.Collections.Generic;
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
        private Dataaccess_blodtryksmåler.Kalibrer kalval;

        public void start()
        {

        }

        public void Execute()
        {
            lT = new Thread(() => formVtommHg());
            lT.Start();

        }

        public DTO_data formVtommHg()
        {
            DTO_data dat = new DTO_data();
            dat = DAL.OpsamlData();
            foreach (var VARIABLE in dat.datalist)
            {
                VARIABLE= VARIABLE*kalval.getFactor();              
            }
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
