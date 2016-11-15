using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Filter
    {
        Logic log = new Logic();
        public DTO_data DatatoPresentation(int i)
        {
            return FiltrerData(log.fromVtommHg());
            // denne metode skal sende data fra filtret og op i præsentationslaget
        }

        public DTO_data FiltrerData(DTO_data dto)
        {
            return dto;
        }

        public DTO_data DatatoCal()
        {
            return FiltrerData(log.dataToKalibrate());
            //Denne metode skal kunne hente spændinger direkte fra logic, sende disse spændinger igennem filteret gemme dem i en dto som kan hentes fra kalibrer klassen.
        }
    }
}