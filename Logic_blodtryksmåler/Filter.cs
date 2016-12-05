using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Filter
    {
        private Analyse analyse_; 

        public Filter()
        {
            analyse_ = new Analyse();
        }

        public void FilterData(ref DTO_data data, bool on)
        {
            int rangelenght = 10;

            for (int i = 0; i < data.datalist.Count; i++)
            {
                IEnumerable<double> range = data.datalist;

                if (i > rangelenght/2)
                    range = range.Skip(i - rangelenght/2);

                range = range.Take(rangelenght);

                if (on == true)
                {
                    data.datalist[i] = range.Average();
                }
            }
            analyse_.findSysOrDia(ref data);
        }
    }
}