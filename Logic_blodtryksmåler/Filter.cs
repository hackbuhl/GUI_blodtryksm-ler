using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Filter: iStrategy
    {
        public DTO_data ActivateFilter()
        {
            throw new System.NotImplementedException();
        }

        public void Execute()
        {
            
        }

        public DTO_data formVtommHg()
        {
            throw new NotImplementedException();
        }

        public bool ZeroAdjust()
        {
            throw new NotImplementedException();
        }

        public DTO_data CalData()
        {
            throw new NotImplementedException();
            //Denne metode skal kunne hente spændinger direkte fra logic, sende disse spændinger igennem filteret gemme dem i en dto som kan hentes fra kalibrer klassen.
        }
    }
}