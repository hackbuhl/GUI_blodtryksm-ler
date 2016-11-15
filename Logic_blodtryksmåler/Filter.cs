using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Filter
    {
        public DTO_data FilterData(DTO_data data)
        {
            double beat = 0;
            int count = 0;
            double valuePre = 0;


            for (int i = 0; i < data.datalist.Count; i++)
            {
                IEnumerable<double> range = data.datalist;

                if (count > 5)
                    range = range.Skip(count - 5);

                range = range.Take(11);

                data.datalist[i] = range.Average();
            }
            return data;
        }
    }
}