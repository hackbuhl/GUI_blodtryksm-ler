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

        //skal denne have spændinger fra logic eller fra filter?? 


        public void Calibrate(DTO_kalibrer kalibrer)
        {
            CalVarialbel = ((kalibrer.Read2 - kalibrer.Read1) / (kalibrer.Måling2 - kalibrer.Måling1));
        }

        public void Update()
        {
            filter.CalData();

        }
    }
}