﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Filter
    {
        private Analyse analyse_; 

        public Filter(Analyse ana)
        {
            analyse_ = ana; 
        }

        public void FilterData(ref DTO_data data)
        {
            int rangelenght = 10;

            for (int i = 0; i < data.datalist.Count; i++)
            {
                IEnumerable<double> range = data.datalist;

                if (i > rangelenght/2)
                    range = range.Skip(i - rangelenght/2);

                range = range.Take(rangelenght);

                data.datalist[i] = range.Average();
            }
            analyse_.findSysOrDia(ref data);
        }
    }
}