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
        int dia_;
        int sys_; 

        /*
        public void FindDiaSys(DTO_data DTO)

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

        public void findMaxOrMin(DTO_data dto_data)
        {

            if (dto_data.datalist != null)
            {
                if (dto_data.datalist.Count > 100)
                {
                    for (int i = dto_data.datalist.Count - 100; i < dto_data.datalist.Count; i++)
                    {
                        if (i > 0 && (dto_data.datalist[i] > 110 || dto_data.datalist[i - 1] > 110))
                        {
                            if (dto_data.datalist[i] < dto_data.datalist[i - 1]) // sikre at vi er på vej ned
                            {
                                dto_data.Systole = i - 1; 
                            }
                        }
                        if (i > 0 && (dto_data.datalist[i] < 110 || dto_data.datalist[i - 1] < 110))
                        {
                            if (dto_data.datalist[i] > dto_data.datalist[i - 1]) // sikre at vi er på vej op
                            {
                                dto_data.Diastole = i - 1;
                            }
                        }
                    }
                }
            }
        }

        public void FindPulse()
        {
        }

        //public double showDia()
        //{
            
            
        //}

    }
}