using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;


namespace Logic_blodtryksmåler
{
    public class Alarm: iAnalyseObserver
    {
        private DTO_alarm dtoAlarm;
        public int Alarmvalues
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void SetAlarm(DTO_alarm dto)
        {
            throw new System.NotImplementedException();
        }

        public void SetToDefault()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int val)
        {
            
        }
    }
}