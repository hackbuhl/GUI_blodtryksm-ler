using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Logic : iStrategy
    {
        private double ZeroA;
        private Dataaccess_blodtryksmåler.GetData DAL;
        private DTO_data dtoData;

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public DTO_data formVtommHg()
        {
            throw new NotImplementedException();
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
