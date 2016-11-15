
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;
using Dataaccess_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Kalibrer 
    {
        private double CalVarialbel;

        private DTO_data dtoData= new DTO_data();
        private Filter filt= new Filter();
        private Dataaccess_blodtryksmåler.Kalibrer dataKalibrer = new Dataaccess_blodtryksmåler.Kalibrer();


<<<<<<< HEAD
        public double data()
        {
            return filt.FilterData(dtoData).datalist.Average(); //filt.DatatoCal().datalist.Average()
        }
=======
        //public double data()
        
           // return filt.DatatoCal().datalist.Average();
        
>>>>>>> origin/master

        public void Calibrate(DTO_kalibrer kalibrer, DTO_login login)
        {
            if (kalibrer.Read1 < kalibrer.Read2)
            {
                CalVarialbel = ((kalibrer.Read2 - kalibrer.Read1)/(kalibrer.Måling2 - kalibrer.Måling1));
            }
            else
            {
                CalVarialbel = ((kalibrer.Read1 - kalibrer.Read2)/kalibrer.Måling1 - kalibrer.Måling2);
            }
            kalibrer.Factor = CalVarialbel;
            dataKalibrer.saveFactor(kalibrer,login);
        }
    }
}