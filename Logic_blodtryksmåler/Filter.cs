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
            List<double> da;
            if (data.datalist.Count > 11)
            {
                for (int i = 0; i < 5; i++)
                {
                    da = new List<double>();
                    for (int j = 0; j < 10; j++)
                    {
                        da.Add(data.datalist[data.datalist.Count-10+j]);
                    }
                    if (on == true)
                    {
                        data.datalist[data.datalist.Count-10+i] = da.Average();
                    }
                }
            }
           // analyse_.findSysOrDia(ref data);
        }
    }
}