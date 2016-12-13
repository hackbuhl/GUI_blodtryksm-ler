using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;


namespace Logic_blodtryksmåler
{
    public class Analyse
    {
        private DTO_blodtryksmåler.DTO_data dataDTO = new DTO_data();
        private bool top = false;
        private Alarm allan = new Alarm();

         
        public void findSysOrDia(ref DTO_data dto_data, List<double> anaList )
        {
            
            if (anaList != null & anaList.Count > 100)
            {
                int counter = 0;
                for (int i = anaList.Count - 100; i < anaList.Count; i++)
                {

                    if (i > 0  && anaList[i] > 95 & top == false & counter>20)
                    {
                        double Rhældning = ((anaList[i] - anaList[i - 1]) +
                                            (anaList[i - 1] - anaList[i - 2]) +
                                            (anaList[i - 2] - anaList[i - 3]) +
                                            (anaList[i - 3] - anaList[i - 4]) +
                                            (anaList[i-4] - anaList[i - 5]) +
                                            (anaList[i - 5] - anaList[i - 6]) +
                                            (anaList[i - 6] - anaList[i - 7]) +
                                            (anaList[i - 7] - anaList[i - 8]))/ 8;
                        if (Rhældning < 0) // sikre at vi er på vej ned
                        {
                            dto_data.Systole = Convert.ToInt32((anaList[i - 4]));
                            
                            top = true;
                            counter = 0;
                            allan.alarmSound(ref dto_data);
                        }
                    }
                    if (i > 0 && anaList[i] < 95 & top == true & counter > 20)
                    {
                        double Rhældning = ((anaList[i] - anaList[i - 1]) +
                                            (anaList[i - 1] - anaList[i - 2]) +
                                            (anaList[i - 2] - anaList[i - 3]) +
                                            (anaList[i - 3] - anaList[i - 4]) +
                                            (anaList[i - 4] - anaList[i - 5]) +
                                            (anaList[i - 5] - anaList[i - 6]) +
                                            (anaList[i - 6] - anaList[i - 7]) +
                                            (anaList[i - 7] - anaList[i - 8])) / 8;
                        if (Rhældning > 0) // sikre at vi er på vej op
                        {
                            dto_data.Diastole = Convert.ToInt32((anaList[i - 4]));
                            
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