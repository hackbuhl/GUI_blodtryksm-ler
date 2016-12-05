﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;


namespace Logic_blodtryksmåler
{
    public class Analyse : AbAnalyse
    {
        private DTO_blodtryksmåler.DTO_data dataDTO=new DTO_data();

        public void findSysOrDia(ref DTO_data dto_data)
        {

            if (dto_data.datalist != null)
            {
                if (dto_data.datalist.Count > 100)
                {
                    for (int i = dto_data.datalist.Count - 100; i < dto_data.datalist.Count; i++)
                    {
                        if (i > 0 && dto_data.datalist[i] > 110)
                        {
                            if (dto_data.datalist[i] < dto_data.datalist[i - 1]) // sikre at vi er på vej ned
                            {
                                dto_data.Systole = Convert.ToInt32((dto_data.datalist[i - 1])); 
                            }
                        }
                        if (i > 0 && dto_data.datalist[i] < 110)
                        {
                            if (dto_data.datalist[i] > dto_data.datalist[i - 1]) // sikre at vi er på vej op
                            {
                                dto_data.Diastole = Convert.ToInt32((dto_data.datalist[i - 1]));
                            }
                        }
                    }
                }
            }
        }
    }
}