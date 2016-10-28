using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Kalibrer 
    {
        private double CalVarialbel;
        private Filter filter;
        private DTO_data dtoData;

        


        public void Calibrate(DTO_kalibrer kalibrer)
        {
            if (kalibrer.Read1 > kalibrer.Read2)
            {
                CalVarialbel = ((kalibrer.Read2 - kalibrer.Read1)/(kalibrer.Måling2 - kalibrer.Måling1));
            }
            else
            {
                CalVarialbel = ((kalibrer.Read1 - kalibrer.Read2)/kalibrer.Måling1 - kalibrer.Måling2);
            }
            // skal kalde en metode som sætter variablen i VtommHg metoden.
        }

        public void Update()
        {
            filter.CalData();

        }
    }
}