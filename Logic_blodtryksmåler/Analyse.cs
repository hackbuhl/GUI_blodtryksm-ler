using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;


namespace Logic_blodtryksmåler
{
    public class Analyse : AbAnalyse
    {
        private DTO_blodtryksmåler.DTO_data dataDTO = new DTO_data();
        private bool top = false;
        private Alarm allan = new Alarm();

         
        public void findSysOrDia(ref DTO_data dto_data)
        {
            
            if (dto_data.FilterList != null & dto_data.FilterList.Count > 100)
            {
                int counter = 0;
                for (int i = dto_data.FilterList.Count - 100; i < dto_data.FilterList.Count; i++)
                {

                    if (i > 0  && dto_data.FilterList[i] > 110 & top == false & counter>30)
                    {
                        double Rhældning = ((dto_data.FilterList[i] - dto_data.FilterList[i - 1]) +
                                            (dto_data.FilterList[i - 1] - dto_data.FilterList[i - 2]) +
                                            (dto_data.FilterList[i - 2] - dto_data.FilterList[i - 3]) +
                                            (dto_data.FilterList[i - 3] - dto_data.FilterList[i - 4]))/4;
                        if (Rhældning < 0) // sikre at vi er på vej ned
                        {
                            dto_data.Systole = Convert.ToInt32((dto_data.FilterList[i - 4]));
                            
                            top = true;
                            counter = 0;
                            allan.alarmSound(ref dto_data);
                        }
                    }
                    if (i > 0 && dto_data.FilterList[i] < 110 & top == true & counter > 30)
                    {
                        double Rhældning = ((dto_data.FilterList[i] - dto_data.FilterList[i - 1]) +
                                            (dto_data.FilterList[i - 1] - dto_data.FilterList[i - 2]) +
                                            (dto_data.FilterList[i - 2] - dto_data.FilterList[i - 3]) +
                                            (dto_data.FilterList[i - 3] - dto_data.FilterList[i - 4]))/4;
                        if (Rhældning > 0) // sikre at vi er på vej op
                        {
                            dto_data.Diastole = Convert.ToInt32((dto_data.FilterList[i - 4]));
                            
                            top = false;
                            counter = 0; 
                            allan.alarmSound(ref dto_data);
                        }
                    }
                    ++counter;
                }
            }
        }

        public Alarm GetAlarm()
        {
            return allan;
        }
    }
}