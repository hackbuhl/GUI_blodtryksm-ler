using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;


namespace Logic_blodtryksmåler
{
    public class Analyse : AbAnalyse
    {
        private DTO_blodtryksmåler.DTO_data dataDTO=new DTO_data();
<<<<<<< HEAD

        public void FindDiaSys(DTO_data DTO)
=======
        /*
        public void FindDiaSys(DTO_data)
>>>>>>> origin/master
        {
            double beat = 0;
            int count = 0;
            double valuePre = 0;
            int lenght = 0;


            foreach (var value in DTO.datalist)
            {
                IEnumerable<double> range = DTO.datalist;

                if (count > lenght/2)
                    range = range.Skip(count - lenght/2);

                range = range.Take(lenght);
            }
        }
        */
        public void FindPulse()
        {
            throw new System.NotImplementedException();
        }

    }
}