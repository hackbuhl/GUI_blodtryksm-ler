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
        private DTO_data dtoData;
        private List<double> ana;

        public Filter()
        {
            analyse_ = new Analyse();
            dtoData = new DTO_data();
            dtoData.FilterList = new List<double>(1);
            ana = new List<double>(1);

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
                    ana.Add(da.Average());
                    if (on == true)
                    {
                        data.datalist[data.datalist.Count - 10 + i] = da.Average();
                    }

                    
                }
                dtoData = data;
                analyse_.findSysOrDia(ref dtoData, ana);
            }

        }

        public Alarm GetAlarm()
        {
            return analyse_.GetAlarm();
        }
    }
}